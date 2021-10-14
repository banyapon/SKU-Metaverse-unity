using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FollowCam : MonoBehaviourPun
{
    Transform target;
    Transform my_trans;

    void Start()
    {
        my_trans = GetComponent<Transform>();

        if (photonView.IsMine)
        {
            target = Camera.main.transform;
        }
    }

    void Update()
    {
        if (!photonView.IsMine)
        {
            return;
        }

        target.position = new Vector3(target.position.x, my_trans.position.y, target.position.z);
        target.LookAt(my_trans);
    }
}