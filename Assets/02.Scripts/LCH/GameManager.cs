using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Name;
    public GameObject InputField;
    public GameObject ConnerctedServer;

    public Text NameText;
    public Text User;

    private NetworkManager netManager;

    void Start()
    {
        PlayerPrefs.DeleteKey("Name");
        netManager = FindObjectOfType<NetworkManager>();
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
            Debug.Log("2 :" + NameText.text);
            PlayerPrefs.SetString("Name", NameText.text);
            netManager.ConnectToServer();
        }
    }
}
