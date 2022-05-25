using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FollowCam : MonoBehaviourPun
{
    private Camera _mainCamera;
    private Transform _cameraPos;
    private Transform _pos;

    void Start()
    {
        if (!photonView.IsMine) return;
        _pos = GetComponent<Transform>();
        _mainCamera = Camera.main;
        _cameraPos = Camera.main.transform;

        _cameraPos.position = new Vector3(_pos.position.x, _pos.position.y + 7.5f, _pos.position.z - 14.0f);
        _cameraPos.rotation = Quaternion.Euler(5f, 0f, 0f);
        _cameraPos.transform.parent = transform;
    }
}