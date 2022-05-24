using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CheckProfessor : MonoBehaviourPunCallbacks
{
    public GameObject micButton;
    public GameObject controlButton;

    void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            if (GameManager.IsToggle1 == true)
            {
                micButton.SetActive(true);
                controlButton.SetActive(true);
            }
        }
    }
}
