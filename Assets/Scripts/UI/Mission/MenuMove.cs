using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/*MissionMove: 부드럽게 움직이는 스크립트*/
public class MenuMove : MonoBehaviour
{
    public GameObject Main_; //부모 창 오브젝트
    public float posx = 812;
    public float r_posx = 506;

    //[1]에는 close 버튼, [2]에는 list
    public GameObject[] videoList = new GameObject[2];
    public GameObject[] audioList = new GameObject[2];
    public GameObject[] effectList = new GameObject[2];

    #region 비디오
    public void VideoOpen()
    {
        Main_.transform.DOMoveX(posx, 0.7f);

        for (int i = 0; i < 2; i++)
        {
            videoList[i].SetActive(true);
            audioList[i].SetActive(false);
            effectList[i].SetActive(false);
        }

        //videoList[1].SetActive(true);
        //imageList[1].SetActive(false);
    }

    public void VideoClose()
    {
        Main_.transform.DOMoveX(r_posx, 0.7f);

        videoList[0].SetActive(false);
    }
    #endregion

    #region 오디오
    public void AudioOpen()
    {
        Main_.transform.DOMoveX(posx, 0.7f);

        for (int i = 0; i < 2; i++)
        {
            videoList[i].SetActive(false);
            audioList[i].SetActive(true);
            effectList[i].SetActive(false);
        }

        //videoList[1].SetActive(false);
        //imageList[1].SetActive(true);
    }

    public void AudioClose()
    {
        Main_.transform.DOMoveX(r_posx, 0.7f);

        audioList[0].SetActive(false);
    }
    #endregion

    #region 기능
    public void EffectOpen()
    {
        Main_.transform.DOMoveX(posx, 0.7f);

        for (int i = 0; i < 2; i++)
        {
            videoList[i].SetActive(false);
            audioList[i].SetActive(false);
            effectList[i].SetActive(true);
        }

        //videoList[1].SetActive(false);
        //imageList[1].SetActive(true);
    }

    public void EffectClose()
    {
        Main_.transform.DOMoveX(r_posx, 0.7f);

        effectList[0].SetActive(false);
    }
    #endregion
}
