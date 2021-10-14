using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerMove : MonoBehaviourPun, IPunObservable
{
    //public Transform _camera;

    private Vector3 remotePos;
    private Quaternion remoteRot;
    //private Quaternion remoteCamRot;

    void Update()
    {
        if (!photonView.IsMine) // Transform Photon 보간
        {
            transform.position = Vector3.Lerp(transform.position, remotePos, 10 * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, remoteRot, 10 * Time.deltaTime);
            //_camera.rotation = Quaternion.Lerp(_camera.rotation, remoteCamRot, 10 * Time.deltaTime);

            return;
        }
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.IsWriting)
        {
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
            //stream.SendNext(_camera.rotation);
        }

        else
        {
            remotePos = (Vector3)stream.ReceiveNext();
            remoteRot = (Quaternion)stream.ReceiveNext();
            //remoteCamRot = (Quaternion)stream.ReceiveNext();
        }
    }
}