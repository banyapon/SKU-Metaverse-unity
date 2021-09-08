using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class NoticeControl : MonoBehaviourPun
{
    public GameObject NoticePanel;
    public GameObject Fail;
    public GameObject isProfessor;
    public GameObject PassWord;
    public GameObject PassWordPanel;
    public GameObject Canvas;
    public InputField PasswordInputField;
    public Text NoticeInputField;
    public Text NoticeText;
    Vector3 StartPos;
    string TmpText;
    bool isNoticeText;
    int count;

    void Start()
    {
        isNoticeText = false;
        count = 0;
        StartPos = NoticeText.transform.position;
    }

    void Update()
    {
        if (isNoticeText == true)
        {
            NoticeText.transform.Translate(-100 * Time.deltaTime, 0, 0);
        }

        if (NoticeText.transform.position.x <= -1550)
        {
            NoticeText.transform.position = StartPos;
            count++;
        }

        if (count > 1) //2번만 반복하도록
        {
            isNoticeText = false;
            count = 0;
            if (NoticeText.text != TmpText)
            {
                NoticeText.text = TmpText;
                isNoticeText = true;
                Debug.Log("NoticeText2 : " + NoticeText.text);
            }
        }
    }

    public void OnClickNotice() //교수인지 아닌지 체크
    {
        if (PlayerPrefs.GetString("Name").Contains("교직원"))
        {
            PassWord.SetActive(true);
        }
        else
        {
            isProfessor.SetActive(true);
        }
    }

    public void OnClickButton() //공지(교수용) 버튼 클릭
    {
        if(PasswordInputField.text == "0000") //비밀번호 0000
        {
            PassWord.SetActive(false);
            NoticePanel.SetActive(true);
        }
        else 
        {
            Debug.Log(PasswordInputField.text);
            Fail.SetActive(true);
            Debug.Log("비밀번호 입력 실패");
        }
    }

    public void NoticeConfirm() //공지사항 작성 후 확인버튼
    {
        //isNoticeText = true;
        NoticePanel.SetActive(false);
        //TmpText = NoticeInputField.text;
        photonView.RPC("SendRPC", RpcTarget.All, NoticeInputField.text);
        //Debug.Log("NoticeInputField.text : " + NoticeInputField.text);
        //Debug.Log("TmpText : " + TmpText);
        /*if (NoticeText.text == "")
        {
            NoticeText.text = TmpText;
        }*/
    }

    [PunRPC]
    public void SendRPC(string isNotice)
    {
        Debug.Log("SendRPC");
        TmpText = isNotice;
        isNoticeText = true;
        
        if (NoticeText.text == "")
        {
            NoticeText.text = TmpText;
        }
    }
}
