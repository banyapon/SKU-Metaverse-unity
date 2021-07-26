using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{
    public GameObject Name;
    public Text NameText;
    public GameObject InputField;
    public GameObject Character;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Name.transform.position = Character.transform.position + new Vector3(0, 2f, 0);
    }


    public void onNameSaveClick()
    {
        Name.GetComponent<TextMesh>().text = NameText.text;
        Character.SetActive(true);
        Name.SetActive(true);
        InputField.SetActive(false);
    }
}
