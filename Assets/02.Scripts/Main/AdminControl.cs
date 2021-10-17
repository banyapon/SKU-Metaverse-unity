using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminControl : MonoBehaviour
{
    public GameObject Password;
    public GameObject ControlPanel;
    public GameObject Fail;

    public InputField PwdText;

    private string password = "941602";

    public void OnClickPwdButton()
    {
        if (PwdText.text == password)
        {
            Password.SetActive(false);
            ControlPanel.SetActive(true);
        }
        else
        {
            Fail.SetActive(true);
        }
    }
}