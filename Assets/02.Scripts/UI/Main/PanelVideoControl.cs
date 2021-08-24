using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class PanelVideoControl : MonoBehaviour
{
    public VideoPlayer video;

    public void videoPlay()
    {
        video.Play();
    }

    public void videoStop()
    {
        video.Stop();
    }

    public void videoPause()
    {
        video.Pause();
    }
}
