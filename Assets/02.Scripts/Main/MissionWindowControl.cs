using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionWindowControl : MonoBehaviour
{
    public GameObject MissionWindow_;
    public GameObject Opendow_;
    public GameObject Closedow_;

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
