using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class Vote7 : MonoBehaviourPunCallbacks
{
    private bool Vote_opportunity = true;
    private int StackNum = 0;
    public Text VoteLive;
    public GameObject Already;

    public void VoteBtn()
    {
        if (Vote_opportunity)
        {
            photonView.RPC("VoteRPC", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity = false;
        }

        else
        {
            Already.SetActive(true);
        }
    }

    void Update()
    {
        VoteLive.text = "투표현황: " + StackNum + "표";
    }

    [PunRPC]
    void VoteRPC(int num)
    {
        StackNum += num;
    }
}
