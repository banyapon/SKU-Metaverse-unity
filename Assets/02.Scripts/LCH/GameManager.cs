using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject Name;
    public GameObject InputField;
    public GameObject ConnerctedServer;
    public GameObject NameFailed;

    public Text NameText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("Name");
    }

    // Update is called once per frame
   
  
    public void onNameSaveClick()
    {
        if(NameText.text == "")
        {
            Debug.Log("1 :" + NameText.text);
            ConnerctedServer.GetComponent<Button>().interactable = false;
            NameFailed.SetActive(true);

        }
        else
        {
            Debug.Log("2 :" + NameText.text);
            PlayerPrefs.SetString("Name", NameText.text);
            InputField.SetActive(false);
        }
    }

    public void FailButtonClick()
    {
        NameFailed.SetActive(false);
        ConnerctedServer.GetComponent<Button>().interactable = true;
    }

   
}
