using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Lobby;
    public GameObject InputField;
    public GameObject toggleGroup;

    private string toggleStr = "<color=#3232FF>(학부생)</color> ";

    public Text NameText;
    public Text User;

    public static bool IsToggle1;

    void Start()
    {
        PlayerPrefs.DeleteKey("Name");
    }

    public void CheckToggle1()
    {
        toggleStr = "<color=#FF8C00>(교직원)</color> ";
        IsToggle1 = true;
    }
    public void CheckToggle2()
    {
        toggleStr = "<color=#3232FF>(학부생)</color> ";
    }
    public void CheckToggle3()
    {
        toggleStr = "<color=#225555>(게스트)</color> ";
    }

    public void onNameSaveClick()
    {
        if(NameText.text == "")
        {
            Debug.Log("1 :" + NameText.text);
            User.text = "<color=#ff0000>이름을 입력해주세요!</color>";
        }
        else
        {
            Debug.Log("2 :" +  toggleStr + NameText.text);
            PlayerPrefs.SetString("Name", toggleStr + NameText.text);
            InputField.SetActive(false);
            toggleGroup.SetActive(false);
            Lobby.SetActive(true);
        }
    }
}
