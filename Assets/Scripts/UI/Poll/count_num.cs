using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count_num : MonoBehaviour
{
    public static int[] teams = new int[19]; //각 팀 득표수를 계산하기 위한 배열, 총 18팀

    private void Awake()
    {
        for(int i=0; i <= 19; i++)
        {
            teams[i] = 0;
        }
    }

}
