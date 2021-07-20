using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicButton : MonoBehaviour
{
    public GameObject Recorder;
    public GameObject Speaker;

    public void Recorder_Off()
    {
        Recorder.SetActive(false);
    }

    public void Recorder_On()
    {
        Recorder.SetActive(true);
    }

    public void Speaker_Off()
    {
        Speaker.SetActive(false);
    }

    public void Speakerr_On()
    {
        Speaker.SetActive(true);
    }
}
