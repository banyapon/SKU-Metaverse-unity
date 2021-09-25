using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionClear : MonoBehaviour
{
    public GameObject Stamp1_;
    public GameObject Stamp2_;
    public GameObject Stamp3_;

    public GameObject CompleteText;
    //public GameObject Particle_;

    //미션 완료
    //설명: 만약 세가지 색상 알파값 모두가 1이 되면 미션완료 축하
    //player 안에 있는 파티클 오브젝트를 on 시켜서 터트리는 방식
    //void Start()
    //{
    //    MissionDone();
    //}

    //void Update()
    //{
    //    Color FirstColor = Stamp1_.GetComponent<Image>().color;
    //    Color SecondColor = Stamp2_.GetComponent<Image>().color;
    //    Color ThirdColor = Stamp3_.GetComponent<Image>().color;
    //    if (FirstColor.a == 1 && SecondColor.a == 1 && ThirdColor.a == 1)
    //    {
    //        //GameObject ParticleMission = GameObject.FindGameObjectWithTag("Particle");
    //        //GameObject Particle = GameObject.FindGameObjectWithTag("Player");

    //        CompleteText.SetActive(true); //축하메세지 on
    //        Stamp1_.SetActive(false);
    //        Stamp2_.SetActive(false);
    //        Stamp3_.SetActive(false);
    //        //Particle_.SetActive(true);
    //    }
    //}

    void Update()
    {
        //Color FirstColor = Stamp1_.GetComponent<Image>().color;
        Color SecondColor = Stamp2_.GetComponent<Image>().color;
        Color ThirdColor = Stamp3_.GetComponent<Image>().color;
        if (SecondColor.a == 1 && ThirdColor.a == 1)
        {
            //GameObject ParticleMission = GameObject.FindGameObjectWithTag("Particle");
            //GameObject Particle = GameObject.FindGameObjectWithTag("Player");

            CompleteText.SetActive(true); //축하메세지 on
            //Stamp1_.SetActive(false);
            Stamp2_.SetActive(false);
            Stamp3_.SetActive(false);
            //Particle_.SetActive(true);
        }
    }
}
