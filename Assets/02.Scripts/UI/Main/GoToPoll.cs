using Photon.Pun.Demo.Cockpit.Forms;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPoll : MonoBehaviour
{

    //버튼을 누르면 투표장소로 돌아갈 수 있게 하는 스크립트

    public void onButtonClick()
    {
        SceneManager.LoadScene("Poll");
    }
}
