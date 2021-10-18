using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BoothVideo : MonoBehaviour
{
    public VideoPlayer VideoPlayer;

    public void VideoPlay()
    {
        VideoPlayer.Play();
        VideoPlayer.SetDirectAudioVolume(0, 0.1f);
    }

    public void VideoStop()
    {
        VideoPlayer.Stop();
    }

    public void VideoPause()
    {
        VideoPlayer.Pause();
    }

    public void VideoVolumeUp()
    {
        if (VideoPlayer.GetDirectAudioVolume(0) < 1)
            // 볼륨 0.1씩 올리기
            VideoPlayer.SetDirectAudioVolume(0, VideoPlayer.GetDirectAudioVolume(0) + 0.1f);
    }

    public void VideoVolumeDown()
    {
        if (VideoPlayer.GetDirectAudioVolume(0) > 0)
            // 볼륨 0.1씩 줄이기
            VideoPlayer.SetDirectAudioVolume(0, VideoPlayer.GetDirectAudioVolume(0) - 0.1f);
    }
}
