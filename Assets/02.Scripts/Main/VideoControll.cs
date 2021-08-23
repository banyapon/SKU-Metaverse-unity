using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControll : MonoBehaviour
{
    public GameObject TeamVideo;
    public VideoPlayer videoClip;

    public GameObject OnButton_;
    public GameObject OffButton_;
    public GameObject PauseButton_;

    bool V_Pause = false;

    //재생
    public void OnPlayVideo()
    {
        TeamVideo.SetActive(true);
        videoClip.Play();
        OnButton_.SetActive(false);
        OffButton_.SetActive(true);
        PauseButton_.SetActive(true);
    }

    //정지
    public void OnStopVideo()
    {
        TeamVideo.SetActive(false);
        videoClip.time = 0f;
        OnButton_.SetActive(true);
        OffButton_.SetActive(false);
        PauseButton_.SetActive(false);
    }

    //일시정지
    public void OnPauseVideo()
    {
        //videoClip.Pause();
        if(V_Pause == false)
        {
            V_Pause = true;
            videoClip.Pause();
        }
        else
        {
            V_Pause = false;
            videoClip.Play();
        }
    }
}
