using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class DefaultRoom
{
    public int maxPlayer;
}

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public List<DefaultRoom> defaultRooms;
    private GameObject spawnedPlayerPrefab;
    public string Name;

    void Start()
    {
        PhotonNetwork.GameVersion = "2.0";
        DontDestroyOnLoad(gameObject);
    }

    public void ConnectToServer()
    {

        Debug.Log("서버에 연결을 시도합니다.");
        PhotonNetwork.ConnectUsingSettings(); // 서버연결

        if (PlayerPrefs.HasKey("Name"))
            PhotonNetwork.NickName = PlayerPrefs.GetString("Name");

    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("서버와 연결되었습니다.");
        base.OnConnectedToMaster();
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("대기실에 입장하였습니다.");

        InitiliazeRoom(0);
    }
    
    public void InitiliazeRoom(int defaultRoomIndex)
    {
        DefaultRoom roomSettings = defaultRooms[defaultRoomIndex];

        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = (byte)roomSettings.maxPlayer;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;

        PhotonNetwork.JoinOrCreateRoom(Name, roomOptions, TypedLobby.Default);
        SceneManager.LoadScene("Main");
        Debug.Log(Name + "룸으로 이동합니다.");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("방 입장에 실패하였습니다.");
        base.OnJoinRandomFailed(returnCode, message);
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

        spawnedPlayerPrefab = PhotonNetwork.Instantiate(ChoiceCharacter.netPlayer, randPos, Quaternion.identity);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedPlayerPrefab);
    }
}
