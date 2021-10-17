using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class InputFieldMove : MonoBehaviourPun
{
    public void KeyStop()
    {
        if (photonView.IsMine)
        {
            gameObject.GetComponent<TPCharacterController3D>().enabled = false;
        }
    }
}