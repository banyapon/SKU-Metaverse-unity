using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnlineControl : MonoBehaviour
{
    public GameObject Password_;
    public GameObject Fail_;

    public GameObject MainPasswordPanel;
    public GameObject audio_;
    public Text hellotext;
    DefaultRoom defaultroom = new DefaultRoom();
    NetworkManager networkmanager = new NetworkManager();
    GameObject obj;

    public InputField PwdText;

    private string password = "20211105";

    public void OnClickPwdButton_main()
    {
        if (PwdText.text == password)
        {
            obj = GameObject.Find("Network Manager");
            //Debug.Log("방 이름 확인: " + obj.GetComponent<NetworkManager>().defaultRooms[0].Name);
            obj.GetComponent<NetworkManager>().defaultRooms[0].Name = password;
            Password_.SetActive(false);
            PwdText.text = "";
            Invoke("CoroutineStart", 0.8f);
        }
        else
        {
            Fail_.SetActive(true);
            PwdText.text = "";
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