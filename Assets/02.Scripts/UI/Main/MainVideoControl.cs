using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Photon.Pun;

public class MainVideoControl : MonoBehaviourPun
{
    public GameObject PassWord;
    public GameObject VideoPanel;
    public GameObject Fail;
    public GameObject VideoPlayer;
    public InputField PwdText;

    public VideoClip[] TeamVideo = new VideoClip[19];

    public void OnClickPwdButton()
    {
        if (PwdText.text == "0000") //비밀번호 0000
        {
            PassWord.SetActive(false);
            VideoPanel.SetActive(true);
        }
        else
        {            
            Fail.SetActive(true);
        }
    }

    #region 버튼
    public void Team1()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 0);
        VideoPanel.SetActive(false);
    }

    public void Team2()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 1);
        VideoPanel.SetActive(false);
    }

    public void Team3()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 2);
        VideoPanel.SetActive(false);
    }

    public void Team4()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 3);
        VideoPanel.SetActive(false);
    }

    public void Team5()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 4);
        VideoPanel.SetActive(false);
    }

    public void Team6()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 5);
        VideoPanel.SetActive(false);
    }

    public void Team7()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 6);
        VideoPanel.SetActive(false);
    }

    public void Team8()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 7);
        VideoPanel.SetActive(false);
    }

    public void Team9()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 8);
        VideoPanel.SetActive(false);
    }

    public void Team10()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 9);
        VideoPanel.SetActive(false);
    }

    public void Team11()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 10);
        VideoPanel.SetActive(false);
    }

    public void Team12()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 11);
        VideoPanel.SetActive(false);
    }

    public void Team13()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 12);
        VideoPanel.SetActive(false);
    }

    public void Team14()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 13);
        VideoPanel.SetActive(false);
    }

    public void Team15()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 14);
        VideoPanel.SetActive(false);
    }

    public void Team16()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 15);
        VideoPanel.SetActive(false);
    }

    public void Team17()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 16);
        VideoPanel.SetActive(false);
    }

    public void Team18()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 17);
        VideoPanel.SetActive(false);
    }

    public void Team19()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 18);
        VideoPanel.SetActive(false);
    }
    #endregion

    [PunRPC]
    public void VideoRPC(int num)
    {
        VideoPlayer.GetComponent<VideoPlayer>().clip = TeamVideo[num];
        VideoPlayer.GetComponent<VideoPlayer>().Play();
    }
}
