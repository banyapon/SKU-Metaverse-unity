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
    public VideoPlayer VideoPlayer;
    public Image ImagePlayer;
    public AudioSource AudioPlayer;
    public InputField PwdText;

    public GameObject FireManager;

    public VideoClip[] TeamVideo = new VideoClip[20];
    public Sprite[] TeamImage = new Sprite[20];
    public AudioClip[] audioSource = new AudioClip[6];

    public void OnClickPwdButton()
    {
        if (PwdText.text == "1726")
        {
            PassWord.SetActive(false);
            VideoPanel.SetActive(true);
        }
        else
        {
            Fail.SetActive(true);
        }
    }

    #region Firework Effect
    public void Fireworks()
    {
        photonView.RPC("FireworksRPC", RpcTarget.AllViaServer, true);
    }

    public void FireworksOff()
    {
        photonView.RPC("FireworksOffRPC", RpcTarget.AllViaServer, false);
    }
    #endregion

    #region ClapEffect
    public void Clap1()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllViaServer, 0);
    }

    public void Clap2()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllViaServer, 1);
    }

    public void Clap3()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllViaServer, 2);
    }
    #endregion

    #region BGM
    public void BGM1()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllViaServer, 3);
    }

    public void BGM2()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllViaServer, 4);
    }

    public void BGM3()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllViaServer, 5);
    }
    #endregion

    #region VideoVolume
    public void VideoVolumeUP()
    {
        photonView.RPC("VideoVolumeUPRPC", RpcTarget.AllViaServer);
    }

    public void VideoVolumeDOWN()
    {
        photonView.RPC("VideoVolumeDOWNRPC", RpcTarget.AllViaServer);
    }
    #endregion

    #region TeamVideo
    public void Vlog()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 19);
    }

    public void Team1()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 0);
    }

    public void Team2()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 1);
    }

    public void Team3()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 2);
    }

    public void Team4()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 3);
    }

    public void Team5()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 4);
    }

    public void Team6()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 5);
    }

    public void Team7()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 6);
    }

    public void Team8()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 7);
    }

    public void Team9()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 8);
    }

    public void Team10()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 9);
    }

    public void Team11()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 10);
    }

    public void Team12()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 11);
    }

    public void Team13()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 12);
    }

    public void Team14()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 13);
    }

    public void Team15()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 14);
    }

    public void Team16()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 15);
    }

    public void Team17()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 16);
    }

    public void Team18()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 17);
    }

    public void Team19()
    {
        photonView.RPC("VideoRPC", RpcTarget.AllViaServer, 18);
    }
    #endregion

    #region TeamImage
    public void Image_Vlog()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 19);
    }

    public void Image_Team1()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 0);
    }

    public void Image_Team2()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 1);
    }

    public void Image_Team3()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 2);
    }

    public void Image_Team4()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 3);
    }

    public void Image_Team5()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 4);
    }

    public void Image_Team6()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 5);
    }

    public void Image_Team7()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 6);
    }

    public void Image_Team8()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 7);
    }

    public void Image_Team9()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 8);
    }

    public void Image_Team10()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 9);
    }

    public void Image_Team11()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 10);
    }

    public void Image_Team12()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 11);
    }

    public void Image_Team13()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 12);
    }

    public void Image_Team14()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 13);
    }

    public void Image_Team15()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 14);
    }

    public void Image_Team16()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 15);
    }

    public void Image_Team17()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 16);
    }

    public void Image_Team18()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 17);
    }

    public void Image_Team19()
    {
        photonView.RPC("ImageRPC", RpcTarget.AllViaServer, 18);
    }
    #endregion

    #region VideoControl
    public void videoPlay()
    {
        photonView.RPC("VideoPlayRPC", RpcTarget.AllViaServer);
    }

    public void videoStop()
    {
        photonView.RPC("VideoStopRPC", RpcTarget.AllViaServer);
    }

    public void videoPause()
    {
        photonView.RPC("VideoPauseRPC", RpcTarget.AllViaServer);
    }
    #endregion

    #region AudioControl
    public void audioStop()
    {
        photonView.RPC("AudioStopRPC", RpcTarget.AllViaServer);
    }
    #endregion


    #region RPC_AudioControl
    [PunRPC]
    public void AudioRPC(int num)
    {
        AudioPlayer.clip = audioSource[num];
        AudioPlayer.Play();
        AudioPlayer.volume = 0.1f;
    }

    [PunRPC]
    public void AudioStopRPC()
    {
        AudioPlayer.Stop();
    }

    #endregion

    #region RPC_Firework Effect
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
    #endregion

    #region RPC_VideoControl
    [PunRPC]
    public void VideoRPC(int num)
    {
        VideoPlayer.clip = TeamVideo[num];
        ImagePlayer.enabled = false;
        VideoPlayer.Play();
        VideoPlayer.SetDirectAudioVolume(0, 0.1f);
    }

    [PunRPC]
    public void VideoPlayRPC()
    {
        VideoPlayer.Play();
        VideoPlayer.SetDirectAudioVolume(0, 0.1f);
    }

    [PunRPC]
    public void VideoStopRPC()
    {
        VideoPlayer.Stop();
    }

    [PunRPC]
    public void VideoPauseRPC()
    {
        VideoPlayer.Pause();
    }

    [PunRPC]
    public void VideoVolumeUPRPC()
    {
        if (VideoPlayer.GetDirectAudioVolume(0) < 1)
            // 볼륨 0.1씩 올리기
            VideoPlayer.SetDirectAudioVolume(0, VideoPlayer.GetDirectAudioVolume(0) + 0.1f);
    }

    [PunRPC]
    public void VideoVolumeDOWNRPC()
    {
        if (VideoPlayer.GetDirectAudioVolume(0) > 0)
            // 볼륨 0.1씩 줄이기
            VideoPlayer.SetDirectAudioVolume(0, VideoPlayer.GetDirectAudioVolume(0) - 0.1f);
    }
    #endregion

    #region RPC_Image
    [PunRPC]
    public void ImageRPC(int num)
    {
        VideoPlayer.Stop();
        ImagePlayer.enabled = true;
        ImagePlayer.sprite = TeamImage[num];
    }
    #endregion
}
