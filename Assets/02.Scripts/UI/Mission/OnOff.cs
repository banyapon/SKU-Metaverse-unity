using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public GameObject imageList;

    public void ImageOnOff()
    {
        bool Active = imageList.activeSelf;

        imageList.SetActive(!Active);
    }
}
