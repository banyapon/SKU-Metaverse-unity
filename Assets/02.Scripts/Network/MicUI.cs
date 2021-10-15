using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Voice.Unity;

public class MicUI : MonoBehaviourPun
{
    private GameObject micUI;
    private Recorder rec;

    void Start()
    {
        rec = FindObjectOfType<Recorder>();
        micUI = gameObject;
        micUI.SetActive(false);
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            if (rec.IsRecording == true)
            {
                photonView.RPC("MicRPC", RpcTarget.AllViaServer, true);
            }
            else
                photonView.RPC("MicRPC", RpcTarget.AllViaServer, false);
        }
    }

    [PunRPC]
    public void MicRPC(bool ismic)
    {
        micUI.SetActive(ismic);
    }
}