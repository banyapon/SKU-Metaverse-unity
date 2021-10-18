using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FollowCam : MonoBehaviourPun
{
    private Transform target;
    private Transform my_trans;

    float zoomSpeed = 10.0f;
    private Camera mainCamera;

    private Transform cameraArm;

    void Start()
    {
        my_trans = GetComponent<Transform>();
        cameraArm = Camera.main.transform;

        if (photonView.IsMine)
        {
            target = Camera.main.transform;
            mainCamera = Camera.main;

            target.position = new Vector3(my_trans.position.x, my_trans.position.y + 7.5f, my_trans.position.z - 11.5f);
            target.rotation = Quaternion.Euler(5f, 0f, 0f);
            target.transform.parent = transform;
        }
    }

    void Update()
    {
        if (!photonView.IsMine)
        {
            return;
        }

        Zoom();
        LookAround();
    }

    private void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.fieldOfView += distance;
        }
    }

    private void LookAround()
    {
        if (Input.GetMouseButton(1))
        {
            Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            Vector3 camAngle = cameraArm.rotation.eulerAngles;
            float x = camAngle.x - mouseDelta.y;

            if (x < 180f)
            {
                x = Mathf.Clamp(x, -1f, 70f);
            }
            else
            {
                x = Mathf.Clamp(x, 335f, 361f);
            }

            cameraArm.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.x, camAngle.z);
        }
    }
}