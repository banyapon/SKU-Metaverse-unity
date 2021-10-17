using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/*MissionMove: 부드럽게 움직이는 스크립트*/
public class MissionMove : MonoBehaviour
{
    //help는 [0], mission은 [1]
    public GameObject[] Main_ = new GameObject[2]; //부모 창 오브젝트
    public float posx = 320;
    public float r_posx = -72;
    public GameObject[] openButton = new GameObject[2];
    public GameObject[] closeButton = new GameObject[2];

    public void HelpOpen()
    {
        Main_[0].transform.DOMoveX(posx, 0.7f);

        openButton[0].SetActive(false);
        closeButton[0].SetActive(true);

        //만약 미션버튼이 on일때
        if (openButton[1].activeSelf == false)
        {
            Main_[1].transform.DOMoveX(r_posx, 0.7f);
            openButton[1].SetActive(true);
            closeButton[1].SetActive(false);
        }
    }

    public void MissionOpen()
    {
        Main_[1].transform.DOMoveX(posx, 0.7f);

        openButton[1].SetActive(false);
        closeButton[1].SetActive(true);

        //만약 헬프버튼이 on일때
        if (openButton[0].activeSelf == false)
        {
            Main_[0].transform.DOMoveX(r_posx, 0.7f);
            openButton[0].SetActive(true);
            closeButton[0].SetActive(false);
        }
    }

    public void Close()
    {
        for (int i = 0; i < 2; i++)
        {
            Main_[i].transform.DOMoveX(r_posx, 0.7f);
            openButton[i].SetActive(true);
            closeButton[i].SetActive(false);
        }
    }
}
