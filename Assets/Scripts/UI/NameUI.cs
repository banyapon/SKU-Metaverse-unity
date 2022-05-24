using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameUI : MonoBehaviour
{
    private Text user;

    void Start()
    {
        user = GetComponent<Text>();
        user.text = PlayerPrefs.GetString("Name");
    }
}