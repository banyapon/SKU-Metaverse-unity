using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkPlayer : MonoBehaviourPun
{
    public Camera _camera;
    public GameObject cam;

    void Start()
    {
        if (photonView.IsMine)
        {
            _camera.tag = "MainCamera";
            AudioListener.volume = 1;
        }

        else
        {
            cam.SetActive(false);
        }
    }

    void Update()
    {
        if (!photonView.IsMine)
        {
            return;
        }
    }
}