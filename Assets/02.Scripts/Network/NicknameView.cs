using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NicknameView : MonoBehaviourPunCallbacks
{
    public void Send()
    {
        photonView.RPC("ChatRPC", RpcTarget.All, PhotonNetwork.NickName);
    }
}
