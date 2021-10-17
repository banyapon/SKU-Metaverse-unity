using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckProfessor : MonoBehaviour
{
    public GameObject micButton;
    public GameObject controlButton;

    void Start()
    {
        if (FindObjectOfType<GameManager>().IsToggle1 == true)
        {
            micButton.SetActive(true);
            controlButton.SetActive(true);
        }    
    }
}
