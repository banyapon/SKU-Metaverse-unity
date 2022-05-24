using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Sound
{
    Bgm,
    Effect,
    MaxCount
}

public class SoundManager : MonoBehaviour
{
    private AudioSource[] _audioSources = new AudioSource[(int)Sound.MaxCount];

    /* Singleton */
    private static SoundManager _instance;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SoundManager();
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this);
        }

        InitSound();
    }

    public void InitSound()
    {
        GameObject root = GameObject.Find("@SoundManager");

        if (root == null)
        {
            root = new GameObject("@SoundManager");
            Object.DontDestroyOnLoad(root);

            for (int i = 0; i < (int)Sound.MaxCount; i++)
            {
                GameObject go = new GameObject(System.Enum.GetNames(typeof(Sound))[i]);
                _audioSources[i] = go.AddComponent<AudioSource>();
                go.transform.parent = root.transform;
            }

            _audioSources[(int)Sound.Bgm].loop = true;
        }
    }

    public void Play(AudioClip audioClip, Sound soundtype = Sound.Effect, float pitch = 1.0f)
    {
        if (audioClip == null)
            return;

        AudioSource audioSource = _audioSources[(int)soundtype];
        audioSource.pitch = pitch;

        if (soundtype == Sound.Bgm)
        {
            if (audioSource.isPlaying)
                audioSource.Stop();

            audioSource.clip = audioClip;
            audioSource.Play();
        }

        if (soundtype == Sound.Effect)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }

    public void PlayWithSpatialBlend(AudioSource audioSource, AudioClip audioClip, float pitch = 1.0f)
    {
        audioSource.pitch = pitch;
        audioSource.spatialBlend = 1;
        audioSource.rolloffMode = AudioRolloffMode.Linear;
        audioSource.minDistance = 1;
        audioSource.maxDistance = 20;
        audioSource.PlayOneShot(audioClip);
    }

    #region Sound Resources
    public AudioClip login;
    public AudioClip effect;

    public void login_BGM()
    {
        this.Play(login, Sound.Bgm);
    }

    public void EffectExample()
    {
        this.Play(effect);
    }
    #endregion
}