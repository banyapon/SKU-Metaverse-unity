using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerName : MonoBehaviourPunCallbacks
{
    private TextMesh _userName;

    void Start()
    {
        if (!PhotonNetwork.IsConnected) return;
        _userName = GetComponent<TextMesh>();
        _userName.text = photonView.Owner.NickName;
    }

    void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }
}