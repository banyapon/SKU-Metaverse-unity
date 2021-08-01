using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PlayerName : MonoBehaviourPunCallbacks
{
    private TextMesh userName;

    void Start()
    {
        userName = GetComponent<TextMesh>();
        userName.text = photonView.Owner.NickName;
    }
}