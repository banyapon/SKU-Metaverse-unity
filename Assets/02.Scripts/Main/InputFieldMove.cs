using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class InputFieldMove : MonoBehaviourPunCallbacks
{
    public GameObject mainInputField;
    public GameObject controlInputField;
    public GameObject Team1;
    public GameObject Team2;
    public GameObject Team3;
    public GameObject Team4;
    public GameObject Team5;
    public GameObject Team6;
    public GameObject Team7;
    public GameObject Team8;
    public GameObject Team9;
    public GameObject Team10;
    public GameObject Team11;
    public GameObject Team12;
    public GameObject Team13;
    public GameObject Team14;
    public GameObject Team15;
    public GameObject Team16;
    public GameObject Team17;
    public GameObject Team18;

    void Update()
    {
        if (PhotonNetwork.IsConnected)
        {
            chatField();
            controlField();
            boothField();
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

    public void boothField()
    {
        if (Team1.activeSelf == true ||
            Team2.activeSelf == true ||
            Team3.activeSelf == true ||
            Team4.activeSelf == true ||
            Team5.activeSelf == true ||
            Team6.activeSelf == true ||
            Team7.activeSelf == true ||
            Team8.activeSelf == true ||
            Team9.activeSelf == true ||
            Team10.activeSelf == true ||
            Team11.activeSelf == true ||
            Team12.activeSelf == true ||
            Team13.activeSelf == true ||
            Team14.activeSelf == true ||
            Team15.activeSelf == true ||
            Team16.activeSelf == true ||
            Team17.activeSelf == true ||
            Team18.activeSelf == true)

        {
            FindObjectOfType<TPCharacterController3D>().enabled = false;
        }

        else
        {
            FindObjectOfType<TPCharacterController3D>().enabled = true;
        }
    }

}