using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class SelectTeam : MonoBehaviourPunCallbacks
{
    private int Vote_opportunity = 3;
    public Text Vote_opportunity2;
    public string Vote;

    private int team1, team2, team3, team4, team5, team6, team7, team8, team9, team10, team11, team12, team13, team14, team15, team16, team17, team18;
    public Text[] VoteLive;

    public void Team1()
    {
        Vote = "Team1";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC1", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team2()
    {
        Vote = "Team2";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC2", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team3()
    {
        Vote = "Team3";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC3", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team4()
    {
        Vote = "Team4";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC4", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team5()
    {
        Vote = "Team5";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC5", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team6()
    {
        Vote = "Team6";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC6", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team7()
    {
        Vote = "Team7";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC7", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team8()
    {
        Vote = "Team8";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC8", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team9()
    {
        Vote = "Team9";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC9", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team10()
    {
        Vote = "Team10";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC10", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team11()
    {
        Vote = "Team11";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC11", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team12()
    {
        Vote = "Team12";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC12", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team13()
    {
        Vote = "Team13";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC13", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team14()
    {
        Vote = "Team14";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC14", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team15()
    {
        Vote = "Team15";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC15", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team16()
    {
        Vote = "Team16";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC16", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team17()
    {
        Vote = "Team17";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC17", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    public void Team18()
    {
        Vote = "Team18";

        if (Vote_opportunity > 0)
        {
            photonView.RPC("VoteRPC18", RpcTarget.AllBufferedViaServer, 1);
            Vote_opportunity -= 1;
            Vote_opportunity2.text = "투표가능 횟수: " + Vote_opportunity + "회";
        }

        else if (Vote_opportunity == 0)
            Vote_opportunity2.text = "<color=#FF3C3C>이미 투표하셨습니다.</color>";
    }

    #region RPC

    [PunRPC]
    void VoteRPC1(int num)
    {
        team1 += num;
        VoteLive[0].text = team1 + "표";
        Debug.Log(team1);
    }

    [PunRPC]
    void VoteRPC2(int num)
    {
        team2 += num;
        VoteLive[1].text = team2 + "표";
    }

    [PunRPC]
    void VoteRPC3(int num)
    {
        team3 += num;
        VoteLive[2].text = team3 + "표";
    }

    [PunRPC]
    void VoteRPC4(int num)
    {
        team4 += num;
        VoteLive[3].text = team4 + "표";
    }

    [PunRPC]
    void VoteRPC5(int num)
    {
        team5 += num;
        VoteLive[4].text = team5 + "표";
    }

    [PunRPC]
    void VoteRPC6(int num)
    {
        team6 += num;
        VoteLive[5].text = team6 + "표";
    }

    [PunRPC]
    void VoteRPC7(int num)
    {
        team7 += num;
        VoteLive[6].text = team7 + "표";
    }

    [PunRPC]
    void VoteRPC8(int num)
    {
        team8 += num;
        VoteLive[7].text = team8 + "표";
    }

    [PunRPC]
    void VoteRPC9(int num)
    {
        team9 += num;
        VoteLive[8].text = team9 + "표";
    }

    [PunRPC]
    void VoteRPC10(int num)
    {
        team10 += num;
        VoteLive[9].text = team10 + "표";
    }

    [PunRPC]
    void VoteRPC11(int num)
    {
        team11 += num;
        VoteLive[10].text = team11 + "표";
    }

    [PunRPC]
    void VoteRPC12(int num)
    {
        team12 += num;
        VoteLive[11].text = team12 + "표";
    }

    [PunRPC]
    void VoteRPC13(int num)
    {
        team13 += num;
        VoteLive[12].text = team13 + "표";
    }

    [PunRPC]
    void VoteRPC14(int num)
    {
        team14 += num;
        VoteLive[13].text = team14 + "표";
    }

    [PunRPC]
    void VoteRPC15(int num)
    {
        team15 += num;
        VoteLive[14].text = team15 + "표";
    }

    [PunRPC]
    void VoteRPC16(int num)
    {
        team16 += num;
        VoteLive[15].text = team16 + "표";
    }

    [PunRPC]
    void VoteRPC17(int num)
    {
        team17 += num;
        VoteLive[16].text = team17 + "표";
    }

    [PunRPC]
    void VoteRPC18(int num)
    {
        team18 += num;
        VoteLive[17].text = team18 + "표";
    }
    #endregion
}