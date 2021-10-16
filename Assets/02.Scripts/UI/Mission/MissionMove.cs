using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/*MissionMove: 부드럽게 움직이는 스크립트*/
public class MissionMove : MonoBehaviour
{
    public GameObject Main_; //부모 창 오브젝트
    public float posx = 1410;
    public float r_posx = 1819;
    public GameObject openButton;
    public GameObject closeButton;

    public void Open()
    {
        Main_.transform.DOMoveX(posx, 0.7f);

        openButton.SetActive(false);
        closeButton.SetActive(true);
    }

    public void Close()
    {
        Main_.transform.DOMoveX(r_posx, 0.7f);

        openButton.SetActive(true);
        closeButton.SetActive(false);
    }
}
