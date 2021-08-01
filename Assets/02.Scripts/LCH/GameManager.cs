using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Name;
    public GameObject InputField;
    public GameObject ConnerctedServer;

    private string toggleStr = "<color=#3232FF>(학부생)</color> ";

    public Text NameText;
    public Text User;

    private NetworkManager netManager;

    void Start()
    {
        PlayerPrefs.DeleteKey("Name");
        netManager = FindObjectOfType<NetworkManager>();
    }

    public void CheckToggle1()
    {
        toggleStr = "<color=#FF8C00>(교수)</color> ";
    }
    public void CheckToggle2()
    {
        toggleStr = "<color=#3232FF>(학부생)</color> ";
    }
    public void CheckToggle3()
    {
        toggleStr = "<color=#225555>(외부인)</color> ";
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
            netManager.ConnectToServer();
        }
    }
}
