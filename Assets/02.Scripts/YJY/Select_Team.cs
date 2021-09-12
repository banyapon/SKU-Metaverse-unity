using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_Team : MonoBehaviour
{
    //Selected_img가 비활성화일 시 선택버튼을 누르면 활성화되게 함

    public GameObject Selected_img;
    public Text count;
    public static int counting;



    private void Awake()
    {
        count.text = "남은 선택 횟수 : " + Select_count.select_count;
    }

    private void Start()
    {
        counting = Select_count.select_count;
    }


    public void OnClickButton()
    {
        if (Selected_img.activeSelf == false && counting > 0)
        {
            Selected_img.SetActive(true);
            counting = counting - 1;
            count.text = "남은 선택 횟수 : " + counting.ToString();
        }
        else if (Selected_img.activeSelf == true)
        {
            Selected_img.SetActive(false);
            counting = counting + 1;
            count.text = "남은 선택 횟수 : " + counting.ToString();
        }
    }

    /*private void Update()
    {
        int counting = Select_count.select_count;
        count.text = "남은 선택 횟수 : " + counting.ToString();
    }*/


}



