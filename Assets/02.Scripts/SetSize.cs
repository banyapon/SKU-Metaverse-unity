using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSize : MonoBehaviour
{
    void Awake()
    {
        Screen.SetResolution(960, 540, false);
    }
}
