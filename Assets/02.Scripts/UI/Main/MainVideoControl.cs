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
    public GameObject ImagePlayer;
    public GameObject AudioPlayer;
    public InputField PwdText;

    public GameObject FireManager;

    public VideoClip[] TeamVideo = new VideoClip[20];
    public Sprite[] TeamImage = new Sprite[20];
    public AudioClip[] audioSource = new AudioClip[3];

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
    public void Fireworks()
    {
        photonView.RPC("FireworksRPC", RpcTarget.All, true);
    }

    public void FireworksOff()
    {
        photonView.RPC("FireworksOffRPC", RpcTarget.All, false);
    }

    public void Clap1()
    {
        photonView.RPC("AudioRPC", RpcTarget.All, 0);
    }

    public void Clap2()
    {
        photonView.RPC("AudioRPC", RpcTarget.All, 1);
    }

    public void Clap3()
    {
        photonView.RPC("AudioRPC", RpcTarget.All, 2);
    }

    public void VideoVolumeUP()
    {
        photonView.RPC("VideoVolumeUPRPC", RpcTarget.All);
    }

    public void VideoVolumeDOWN()
    {
        photonView.RPC("VideoVolumeDOWNRPC", RpcTarget.All);
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

    public void audioStop()
    {
        photonView.RPC("AudioStopRPC", RpcTarget.All);
    }
    #endregion

    #region 이미지
    public void Image_Vlog()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 19);
    }

    public void Image_Team1()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 0);
    }

    public void Image_Team2()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 1);
    }

    public void Image_Team3()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 2);
    }

    public void Image_Team4()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 3);
    }

    public void Image_Team5()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 4);
    }

    public void Image_Team6()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 5);
    }

    public void Image_Team7()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 6);
    }

    public void Image_Team8()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 7);
    }

    public void Image_Team9()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 8);
    }

    public void Image_Team10()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 9);
    }

    public void Image_Team11()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 10);
    }

    public void Image_Team12()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 11);
    }

    public void Image_Team13()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 12);
    }

    public void Image_Team14()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 13);
    }

    public void Image_Team15()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 14);
    }

    public void Image_Team16()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 15);
    }

    public void Image_Team17()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 16);
    }

    public void Image_Team18()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 17);
    }

    public void Image_Team19()
    {
        photonView.RPC("ImageRPC", RpcTarget.All, 18);
    }
    #endregion

    [PunRPC]
    public void AudioRPC(int num)
    {
        AudioPlayer.GetComponent<AudioSource>().clip = audioSource[num];
        AudioPlayer.GetComponent<AudioSource>().Play();
        AudioPlayer.GetComponent<AudioSource>().volume = 0.1f;
    }

    [PunRPC]
    public void AudioStopRPC()
    {
        AudioPlayer.GetComponent<AudioSource>().Stop();
    }

    [PunRPC]
    public void FireworksRPC(bool fireplay)
    {
        FireManager.gameObject.SetActive(fireplay);
    }

    [PunRPC]
    public void FireworksOffRPC(bool fireplay2)
    {
        FireManager.gameObject.SetActive(fireplay2);
    }

    [PunRPC]
    public void VideoRPC(int num)
    {
        VideoPlayer.GetComponent<VideoPlayer>().clip = TeamVideo[num];
        ImagePlayer.GetComponent<Image>().enabled = false;
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

    [PunRPC]
    public void ImageRPC(int num)
    {
        VideoPlayer.GetComponent<VideoPlayer>().Stop();
        ImagePlayer.GetComponent<Image>().enabled = true;
        ImagePlayer.GetComponent<Image>().sprite = TeamImage[num];
    }

    [PunRPC]
    public void VideoVolumeUPRPC()
    {
        if (VideoPlayer.GetComponent<VideoPlayer>().GetDirectAudioVolume(0) < 1)
            // 볼륨 0.1씩 올리기
            VideoPlayer.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, VideoPlayer.GetComponent<VideoPlayer>().GetDirectAudioVolume(0) + 0.1f);
    }

    [PunRPC]
    public void VideoVolumeDOWNRPC()
    {
        if (VideoPlayer.GetComponent<VideoPlayer>().GetDirectAudioVolume(0) > 0)
            // 볼륨 0.1씩 줄이기
            VideoPlayer.GetComponent<VideoPlayer>().SetDirectAudioVolume(0, VideoPlayer.GetComponent<VideoPlayer>().GetDirectAudioVolume(0) - 0.1f);
    }
}
