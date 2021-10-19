using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    /*private GameObject spawnedPlayerPrefab;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("새로운 플레이어가 입장하였습니다.");
        base.OnPlayerEnteredRoom(newPlayer);
    }

    public override void OnJoinedRoom()
    {
        Vector3 pos = new Vector3(-40f, 0f, -15f);
        Vector3 randPos = pos + Random.insideUnitSphere * 5;
        randPos.y = 0;
        spawnedPlayerPrefab = PhotonNetwork.Instantiate(cName, randPos, Quaternion.identity);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedPlayerPrefab);
    }*/
}