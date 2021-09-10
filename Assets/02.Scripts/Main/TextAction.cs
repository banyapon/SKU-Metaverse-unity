using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAction : MonoBehaviour
{
    //Text CompleteText;
    //float time;

    //private void Start()
    //{
    //    int a = gameObject.GetComponent<Text>().fontSize;
    //    time += Time.deltaTime;
    //    for(int i =1; i <= 20; i++)
    //    {
    //        a = i;
    //        if (a == 50)
    //        {
    //            a = 30;
    //        }
    //    }
    //}

    public GameObject CompleteText;
    float time = 0;
    public float _size = 2;

    public float _upSizeTime = 0.1f;

    void Update()
    {
        if (time <= _upSizeTime)
        {
            transform.localScale = Vector3.one * (1 + _size * time);
        }
        else if (time <= _upSizeTime * 2)
        {
            transform.localScale = Vector3.one * (2 * _size * _upSizeTime + 1 - time * _size);
        }
        else
        {
            transform.localScale = Vector3.one;
        }
        time += Time.deltaTime;
    }

    public void resetAnim()
    {
        time = 0;
    }

}
