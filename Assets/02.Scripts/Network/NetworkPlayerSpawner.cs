using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    private GameObject spawnedPlayerPrefab;
    public string choiceCharacter;

    public override void OnJoinedRoom()
    {
        Vector3 randPos = Random.insideUnitSphere * 10;
        randPos.y = 0;
        spawnedPlayerPrefab = PhotonNetwork.Instantiate(choiceCharacter, randPos, Quaternion.identity);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedPlayerPrefab);
    }

    private void Update()
    {
        DontDestroyOnLoad(this);
    }
}