using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Voice.Unity;

public class MicControl : MonoBehaviour
{
    public GameObject MicOn;
    public GameObject MicOff;
    public Text Mic;
    public AudioSource audioSource;
    public AudioClip MicOnEffect;
    public AudioClip MicOffEffect;

    private Recorder rec;

    private void Start()
    {
        rec = FindObjectOfType<Recorder>();
        audioSource = GetComponent<AudioSource>();
    }

    public void MicButton()
    {
        if (rec.IsRecording == true)
        {
            rec.IsRecording = false;
            MicOn.SetActive(false);
            MicOff.SetActive(true);
            Mic.text = "<color=#1E1E1E>마이크 꺼짐</color>";
            audioSource.PlayOneShot(MicOffEffect);
        }
        else
        {
            rec.IsRecording = true;
            MicOff.SetActive(false);
            MicOn.SetActive(true);
            Mic.text = "<color=#FF3C3C>마이크 켜짐</color>";
            audioSource.PlayOneShot(MicOnEffect);
        }
    }
}