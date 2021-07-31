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
        if (rec.TransmitEnabled == true)
        {
            rec.TransmitEnabled = false;
            MicOn.SetActive(false);
            MicOff.SetActive(true);
            Mic.text = "<color=#C0C0C0>마이크 꺼짐</color>";
            audioSource.PlayOneShot(MicOffEffect);
        }
        else
        {
            rec.TransmitEnabled = true;
            MicOff.SetActive(false);
            MicOn.SetActive(true);
            Mic.text = "마이크 켜짐";
            audioSource.PlayOneShot(MicOnEffect);
        }
    }
}
