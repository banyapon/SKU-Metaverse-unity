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

    public VideoClip[] TeamVideo = new VideoClip[20];

    public void OnClickPwdButton()
    {
        if (PwdText.text == "1726") //비밀번호 1726
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
    public void Vlog()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 19);
    }

    public void Team1()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 0);
    }

    public void Team2()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 1);
    }

    public void Team3()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 2);
    }

    public void Team4()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 3);
    }

    public void Team5()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 4);
    }

    public void Team6()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 5);
    }

    public void Team7()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 6);
    }

    public void Team8()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 7);
    }

    public void Team9()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 8);
    }

    public void Team10()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 9);
    }

    public void Team11()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 10);
    }

    public void Team12()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 11);
    }

    public void Team13()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 12);
    }

    public void Team14()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 13);
    }

    public void Team15()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 14);
    }

    public void Team16()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 15);
    }

    public void Team17()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 16);
    }

    public void Team18()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 17);
    }

    public void Team19()
    {
        photonView.RPC("VideoRPC", RpcTarget.All, 18);
    }
    #endregion

    #region 컨트롤
    public void videoPlay()
    {
        photonView.RPC("VideoPlayRPC", RpcTarget.All);
    }

    public void videoStop()
    {
        photonView.RPC("VideoStopRPC", RpcTarget.All);
    }

    public void videoPause()
    {
        photonView.RPC("VideoPauseRPC", RpcTarget.All);
    }
    #endregion

    [PunRPC]
    public void VideoRPC(int num)
    {
        VideoPlayer.GetComponent<VideoPlayer>().clip = TeamVideo[num];
        VideoPlayer.GetComponent<VideoPlayer>().Play();
        VideoPlayer.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.1f);
    }

    [PunRPC]
    public void VideoPlayRPC()
    {
        VideoPlayer.GetComponent<VideoPlayer>().Play();
        VideoPlayer.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, 0.1f);
    }

    [PunRPC]
    public void VideoStopRPC()
    {
        VideoPlayer.GetComponent<VideoPlayer>().Stop();
    }

    [PunRPC]
    public void VideoPauseRPC()
    {
        VideoPlayer.GetComponent<VideoPlayer>().Pause();
    }
}
