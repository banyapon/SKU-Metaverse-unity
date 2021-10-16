using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerName : MonoBehaviourPunCallbacks
{
    private TextMesh userName;

    void Start()
    {
        userName = GetComponent<TextMesh>();

        if (PhotonNetwork.IsConnected)
        {
            userName.text = photonView.Owner.NickName;
        }

        else
            Debug.Log("서버에 연결되어 있지 않음");
    }
}