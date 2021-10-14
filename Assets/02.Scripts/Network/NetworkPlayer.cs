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

        if (!photonView.IsMine)
        {
            cam.SetActive(false);
            AudioListener.volume = 0;
        }
    }

    /*void Update()
    {
        if (!photonView.IsMine)
        {
            cam.SetActive(false);
            AudioListener.volume = 0;
            return;
        }
    }*/
}