using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyAnimation : MonoBehaviour
{
    public void G_KeyAnmation()
    {
        Input.GetKeyDown(KeyCode.G);
        Debug.Log("G_KeyAnmation");
    }
}
