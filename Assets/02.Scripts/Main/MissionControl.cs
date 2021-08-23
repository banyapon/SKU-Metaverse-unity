using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionControl : MonoBehaviour
{
    #region 코드 설명
    //Stamp1,2,3 태그 버튼들을 누르면 그에 맞는 도장의 알파값이 255로 변하는 구조
    #endregion

    GameObject VideoButton;
    GameObject CaptureButton;
    GameObject SungkyulButton;

    public GameObject Stamp3_;

    int count_;

    public GameObject MissionWindow_;
    public GameObject Opendow_;
    public GameObject Closedow_;

    //성결이 도장
    public void OnStamp_3()
    {
        count_ = 1;
        if (count_ == 1)
        {
            Color SColor = Stamp3_.GetComponent<Image>().color;
            SColor.a = 1f;
            Stamp3_.GetComponent<Image>().color = SColor;
        }
    }

    //미션창 열기
    public void OpenMission()
    {
        MissionWindow_.SetActive(true);
        Opendow_.SetActive(false);
        Closedow_.SetActive(true);
    }

    //미션창 닫기
    public void CloseMission()
    {
        MissionWindow_.SetActive(false);
        Opendow_.SetActive(true);
        Closedow_.SetActive(false);
    }
}
