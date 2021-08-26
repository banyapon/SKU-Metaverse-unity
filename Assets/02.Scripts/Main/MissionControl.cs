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

    public GameObject Stamp1_;
    public GameObject Stamp2_;
    public GameObject Stamp3_;

    public GameObject CompleteText;
    public GameObject ParticleMission;

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

    //미션 완료
    //설명: 만약 세가지 색상 알파값 모두가 1이 되면 미션완료 축하
    //player 안에 있는 파티클 오브젝트를 on 시켜서 터트리는 방식
    void Update()
    {
        Color FirstColor = Stamp1_.GetComponent<Image>().color;
        Color SecondColor = Stamp2_.GetComponent<Image>().color;
        Color ThirdColor = Stamp3_.GetComponent<Image>().color;
        if (FirstColor.a == 1 && SecondColor.a == 1 && ThirdColor.a == 1)
        {
            //GameObject ParticleMission = GameObject.FindGameObjectWithTag("Particle");
            //GameObject Particle = GameObject.FindGameObjectWithTag("Player");
            
            CompleteText.SetActive(true); //축하메세지 on
            Stamp1_.SetActive(false);
            Stamp2_.SetActive(false);
            Stamp3_.SetActive(false);
            ParticleMission.SetActive(true);
        }
    }

    #region 미션창 열기닫기
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
    #endregion
}
