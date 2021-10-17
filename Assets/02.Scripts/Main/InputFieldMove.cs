using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class InputFieldMove : MonoBehaviourPunCallbacks
{
    public GameObject mainInputField;
    public GameObject controlInputField;

    void Update()
    {
        if (PhotonNetwork.IsConnected)
        {
            chatField();
            controlField();
        }
    }

    public void chatField()
    {
        if (mainInputField.GetComponent<InputField>().isFocused == true)
        {
            FindObjectOfType<TPCharacterController3D>().enabled = false;
        }

        else
        {   
            FindObjectOfType<TPCharacterController3D>().enabled = true;
        }
    }

    public void controlField()
    {
        if (controlInputField.activeSelf == true)
        {
            if (controlInputField.GetComponent<InputField>().isFocused == true)
            {
                FindObjectOfType<TPCharacterController3D>().enabled = false;
            }

            else
            {
                FindObjectOfType<TPCharacterController3D>().enabled = true;
            }
        }
    }
}