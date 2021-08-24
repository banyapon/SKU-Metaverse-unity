using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MainVideoControl : MonoBehaviour
{
    public GameObject PassWord;
    public GameObject VideoPanel;
    public GameObject Fail;
    public GameObject VideoPlayer;
    public InputField PwdText;
    public VideoClip Team1Video;
    public VideoClip Team2Video;
    public VideoClip Team3Video;
    public VideoClip Team4Video;
    public VideoClip Team5Video;
    public VideoClip Team6Video;
    public VideoClip Team7Video;
    public VideoClip Team8Video;
    public VideoClip Team9Video;
    public VideoClip Team10Video;
    public VideoClip Team11Video;
    public VideoClip Team12Video;
    public VideoClip Team13Video;
    public VideoClip Team14Vide;
    public VideoClip Team15Vide;
    public VideoClip Team16Video;
    public VideoClip Team17Video;
    public VideoClip Team18Video;
    public VideoClip Team19Video;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPwdButton() //공지(교수용) 버튼 클릭
    {
        if (PwdText.text == "0000") //비밀번호 0000
        {
            PassWord.SetActive(false);
            VideoPanel.SetActive(true);
        }
        else
        {
            
            Fail.SetActive(true);
        }
    }
    public void Team1()
    {
        VideoPlayer.GetComponent<VideoPlayer>().clip = Team1Video;
        VideoPanel.SetActive(false);
    }

    public void Team2()
    {
        VideoPlayer.GetComponent<VideoPlayer>().clip = Team2Video;
        VideoPanel.SetActive(false);
    }
}
