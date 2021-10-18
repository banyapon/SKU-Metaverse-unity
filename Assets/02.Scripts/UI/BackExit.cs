using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class BackExit : MonoBehaviourPunCallbacks
{
    public void Disconnect()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Lobby");
    }
    public override void OnDisconnected(DisconnectCause cause) => print("연결끊김");
}
