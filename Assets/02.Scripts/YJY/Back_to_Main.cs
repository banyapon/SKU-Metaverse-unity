using Photon.Pun.Demo.Cockpit.Forms;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_to_Main : MonoBehaviour
{

    //버튼을 누르면 다시 엑스포 장소로 돌아갈 수 있게 하는 스크립트

    public void onButtonClick()
    {
        SceneManager.LoadScene("Main");
    }
}
