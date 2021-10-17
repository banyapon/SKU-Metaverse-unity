using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckProfessor : MonoBehaviour
{
    public GameObject micButton;

    void Start()
    {
        if (FindObjectOfType<GameManager>().IsToggle1 == true)
        {
            micButton.SetActive(true);
        }    
    }
}
