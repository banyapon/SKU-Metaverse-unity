using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;

public class NetworkVoting : MonoBehaviourPun
{
    void Update()
    {
        if (photonView)
        {
            photonView.RPC("Vote", RpcTarget.AllBuffered, 1);
        }
    }
    [PunRPC]
    public void Vote(int value)
    {

    }
}
