using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FollowCam : MonoBehaviourPun
{
    Transform target;
    Transform my_trans;

    float zoomSpeed = 10.0f;
    Camera mainCamera;

    void Start()
    {
        my_trans = GetComponent<Transform>();

        if (photonView.IsMine)
        {
            target = Camera.main.transform;
            mainCamera = Camera.main;

            target.position = new Vector3(my_trans.position.x, my_trans.position.y + 7.5f, my_trans.position.z - 10.5f);
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
    }

    private void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.fieldOfView += distance;
        }
    }
}