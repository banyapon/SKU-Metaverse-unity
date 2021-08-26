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
    public string Name;
    public string sceneName;
    public int maxPlayer;
}

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public List<DefaultRoom> defaultRooms;
    public GameObject roomUI;
    public GameObject InputField;
    public GameObject toggleGroup;

    public Text NameText;

    void Start()
    {
        PhotonNetwork.GameVersion = "0.1";
        PhotonNetwork.AutomaticallySyncScene = true; // 마스터 클라이언트로 동기화
    }

    public void ConnectToServer()
    {
        if (NameText.text == "")
        {
            Debug.Log("null");
        }

        else
        {
            InputField.SetActive(false);
            toggleGroup.SetActive(false);
            Debug.Log("서버에 연결을 시도합니다.");
            PhotonNetwork.ConnectUsingSettings(); // 서버연결
            if (PlayerPrefs.HasKey("Name"))
                PhotonNetwork.NickName = PlayerPrefs.GetString("Name");
        }
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
        roomUI.SetActive(true);
    }
    
    public void InitiliazeRoom(int defaultRoomIndex)
    {
        DefaultRoom roomSettings = defaultRooms[defaultRoomIndex];

        SceneManager.LoadScene(roomSettings.sceneName);

        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = (byte)roomSettings.maxPlayer;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;

        PhotonNetwork.JoinOrCreateRoom(roomSettings.Name, roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("방에 입장하였습니다.");
        base.OnJoinedRoom();
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("새로운 플레이어가 입장하였습니다.");
        base.OnPlayerEnteredRoom(newPlayer);
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("방 입장에 실패하였습니다.");
        base.OnJoinRandomFailed(returnCode, message);
    }
}
