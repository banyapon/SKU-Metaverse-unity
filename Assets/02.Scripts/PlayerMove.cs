using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerMove : MonoBehaviourPun, IPunObservable
{
    public Transform _camera;

    public float moveSpeed = 10.0f;
    public float rotateSpeed = 200.0f;
    public float jumpPower = 15.0f;
    public float gravity = -50.0f;

    private float yVelocity = 0.0f;
    private float camAngle;
    private float bodyAngle;

    CharacterController cc;

    private Vector3 remotePos;
    private Quaternion remoteRot;
    private Quaternion remoteCamRot;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (!photonView.IsMine) // Transform Photon 보간
        {
            transform.position = Vector3.Lerp(transform.position, remotePos, 10 * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, remoteRot, 10 * Time.deltaTime);
            _camera.rotation = Quaternion.Lerp(_camera.rotation, remoteCamRot, 10 * Time.deltaTime);

            return;
        }

        RotateCamera(); // 카메라 회전
        RotateBody(); // 플레이어 회전
        Move(); // 플레이어 이동
    }

    private void RotateCamera()
    {
        camAngle += Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
        camAngle = Mathf.Clamp(camAngle, -60, 60);

        _camera.localEulerAngles = new Vector3(-camAngle, 0, 0);
    }

    private void RotateBody()
    {
        bodyAngle += Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

        transform.eulerAngles = new Vector3(0, bodyAngle, 0);
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v) * moveSpeed; // 이동하는 방향
        dir = _camera.TransformDirection(dir); // 카메라가 바라보는 방향으로 방향 전환

        if (cc.isGrounded) // 바닥에 있으면 중력가속도 적용하지 않음
        {
            yVelocity = 0;
        }

        if (Input.GetButtonDown("Jump")) // 점프
        {
            yVelocity = jumpPower;
        }

        yVelocity += gravity * Time.deltaTime; // 중력
        dir.y = yVelocity;

        cc.Move(dir * Time.deltaTime);  // 이동
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.IsWriting)
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
            stream.SendNext(_camera.rotation);
        }
        else
        {
            remotePos = (Vector3)stream.ReceiveNext();
            remoteRot = (Quaternion)stream.ReceiveNext();
            remoteCamRot = (Quaternion)stream.ReceiveNext();
        }
    }
}