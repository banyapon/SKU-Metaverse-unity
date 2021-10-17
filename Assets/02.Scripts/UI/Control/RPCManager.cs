using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Photon.Pun;

public class RPCManager : MonoBehaviourPun
{
    public VideoPlayer VideoPlayer;
    public Image ImagePlayer;
    public AudioSource AudioPlayer;
    public GameObject EffectManager;

    public VideoClip[] TeamVideo = new VideoClip[3];
    public Sprite[] TeamImage = new Sprite[19];
    public AudioClip[] audioSource = new AudioClip[6];


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
        photonView.RPC("AudioRPC", RpcTarget.AllBufferedViaServer, 3);
    }

    public void BGM2()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllBufferedViaServer, 4);
    }

    public void BGM3()
    {
        photonView.RPC("AudioRPC", RpcTarget.AllBufferedViaServer, 5);
    }
    #endregion

    #region VideoVolume
    public void VideoVolumeUP()
    {
        photonView.RPC("VideoVolumeUPRPC", RpcTarget.AllBufferedViaServer);
    }

    public void VideoVolumeDOWN()
    {
        photonView.RPC("VideoVolumeDOWNRPC", RpcTarget.AllBufferedViaServer);
    }
    #endregion

    #region AudioVolume
    public void AudioVolumeUP()
    {
        photonView.RPC("AudioVolumeUP", RpcTarget.AllBufferedViaServer);
    }

    public void AudioVolumeDOWN()
    {
        photonView.RPC("AudioVolumeDOWN", RpcTarget.AllBufferedViaServer);
    }
    #endregion

    #region TeamVideo
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
    #endregion

    #region TeamImage
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

    [PunRPC]
    public void AudioVolumeUp()
    {
        if (AudioPlayer.volume < 1)
            // 볼륨 0.1씩 올리기
            AudioPlayer.volume += 0.1f;
    }

    [PunRPC]
    public void AudioVolumeDown()
    {
        if (AudioPlayer.volume > 0)
        {
            // 볼륨 0.1씩 내리기
            AudioPlayer.volume -= 0.1f;
        }
    }

    #endregion

    #region RPC_Firework Effect
    [PunRPC]
    public void FireworksRPC(bool fireplay)
    {
        EffectManager.gameObject.SetActive(fireplay);
    }

    [PunRPC]
    public void FireworksOffRPC(bool fireplay2)
    {
        EffectManager.gameObject.SetActive(fireplay2);
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