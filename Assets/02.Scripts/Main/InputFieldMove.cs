using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldMove : MonoBehaviour
{
    public GameObject mainInputField;
    public GameObject controlInputField;

    void Update()
    {
        chatField();
        controlField();
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