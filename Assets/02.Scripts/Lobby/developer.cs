using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class developer : MonoBehaviour
{
    public GameObject Text;
    
    public void devButton()
    {//170 -405
        Debug.Log(Text.transform.position);
        Text.transform.Translate(0f, 150.0f, 0f);
    }
}
