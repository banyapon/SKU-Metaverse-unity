using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float XrotateSpeed = 1.0f;
    public float YrotateSpeed = 1.0f;
    public float zoomSpeed = 10.0f;

    public Camera mainCamera;

    void Update()
    {
        Zoom();
        //Rotate();
    }

    private void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.fieldOfView += distance;
        }
    }

    private void Rotate()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 rot = transform.rotation.eulerAngles;
            rot.y += Input.GetAxis("Mouse X") * XrotateSpeed;
            //rot.x += -1 * Input.GetAxis("Mouse Y") * YrotateSpeed;
            Quaternion q = Quaternion.Euler(rot);
            q.z = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, q, 2f);
        }
    }
}