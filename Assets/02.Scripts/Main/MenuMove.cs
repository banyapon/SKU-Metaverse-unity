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
    public GameObject[] imageList = new GameObject[2];

    public void VideoOpen()
    {
        Main_.transform.DOMoveX(posx, 0.7f);

        for (int i = 0; i < 2; i++)
        {
            videoList[i].SetActive(true);
            imageList[i].SetActive(false);
        }

        //videoList[1].SetActive(true);
        //imageList[1].SetActive(false);
    }

    public void VideoClose()
    {
        Main_.transform.DOMoveX(r_posx, 0.7f);

        videoList[0].SetActive(false);
    }

    public void ImageOpen()
    {
        Main_.transform.DOMoveX(posx, 0.7f);

        for (int i = 0; i < 2; i++)
        {
            videoList[i].SetActive(false);
            imageList[i].SetActive(true);
        }

        //videoList[1].SetActive(false);
        //imageList[1].SetActive(true);
    }

    public void ImageClose()
    {
        Main_.transform.DOMoveX(r_posx, 0.7f);

        imageList[0].SetActive(false);
    }
}
