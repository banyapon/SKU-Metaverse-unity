using Photon.Pun.Demo.Cockpit.Forms;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class forSubmit : MonoBehaviour
{
    //private static int[] teams = new int[18]; //각 팀 득표수를 계산하기 위한 배열, 총 18팀

    public GameObject[] teams_obj = new GameObject[18]; //투표창 18개의 activeSelf를 확인하기 위한 배열

    /*private void Start()
    {
        for(int i = 0; i < 18; i++)
        {
            teams[i] = 0;
            Debug.Log("teams"+(i+1)+" : "+ teams[i]);
        }
    }
    */
    public void OnclickButton()
    {
        OnClickforSubmit();
        SceneManager.LoadScene("YJY_last");
        for (int i = 0; i < 18; i++)
        {
            Debug.Log("teams" + (i + 1) + " : "+ count_num.teams[i]);
        }

    }
    // Start is called before the first frame update
    public void OnClickforSubmit()
    {
        for(int i=0; i < 18; i++)
        {
            if (teams_obj[i].activeSelf == true)
            {
                count_num.teams[i]++;
            }
        }
    }


}


