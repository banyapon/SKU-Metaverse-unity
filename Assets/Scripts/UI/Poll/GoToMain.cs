using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{
    private GameObject Selected_done;
    public void Start()
    {
        Selected_done = GameObject.FindGameObjectWithTag("Selected done");
    }
    public void OnclickButton()
    {
        Selected_done.SetActive(false);
        //SceneManager.LoadScene("Main"); //카메라가 다시 제대로 전환되면 살릴 계획
        Application.Quit(); //임시
    }
}
