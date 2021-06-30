using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkPlayer : MonoBehaviourPunCallbacks
{
    public PhotonView PV;
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 80.0f;

    void Start()
    {
        PV = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (PV.IsMine)
        {
            float Move = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            float Rotate = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;

            transform.Translate(0, 0, Move);
            transform.Rotate(0, Rotate, 0);
        }
    }
}