using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnlineControl : MonoBehaviour
{
    public GameObject Password_;

    public GameObject MainPasswordPanel;
    public GameObject audio_;
    public Text hellotext;

    // public DefaultRoom privateRoom;
    private NetworkManager netManager;

    public InputField PwdText;

    private void Start()
    {
        netManager = FindObjectOfType<NetworkManager>();
    }

    public void OnClickPwdButton_main()
    {
        if (PwdText.text != null)
        {
            // netManager.Name = PwdText.text;
            Password_.SetActive(false);
            Invoke("CoroutineStart", 0.8f);
        }
    }

    //환영합니다
    public void CoroutineStart()
    {
        StartCoroutine(HelloCoroutine());
        Invoke("OnOnline", 2.0f);
    }

    IEnumerator HelloCoroutine()
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.05f;
            yield return new WaitForSeconds(0.01f);
            hellotext.color = new Color(255, 212, 0, fadeCount);
        }
    }

    //배경off, audio on
    public void OnOnline()
    {
        MainPasswordPanel.SetActive(false);
        audio_.SetActive(true);
        hellotext.enabled = false;
    }
}