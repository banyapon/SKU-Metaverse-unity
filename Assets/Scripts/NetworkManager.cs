using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public string roomName = "testRoom";
    public byte maxPlayer = 16;
    private GameObject _networkPlayer;

    private readonly string _gameVersion = "1.0";
    private static NetworkManager _instance;

    public static NetworkManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new NetworkManager();
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        
        else
        {
            Destroy(this);
        }

        PhotonNetwork.GameVersion = _gameVersion;
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void ConnectToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conneted to Server");
        Debug.Log("Server Rate: " + PhotonNetwork.SendRate);
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log($"PhotonNetwork.InLobby: {PhotonNetwork.InLobby}");
        InitRoom();
    }

    private void InitRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = maxPlayer;
        roomOptions.IsOpen = true;
        roomOptions.IsVisible = true;

        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
        PhotonNetwork.LoadLevel("Main");
    }

    public override void OnJoinedRoom()
    {
        CreatePlayer();
        Debug.Log($"PhotonNetwork.InRoom: {PhotonNetwork.InRoom}");
        Debug.Log($"CurrentRoom: {PhotonNetwork.CurrentRoom.Name}");
        Debug.Log($"PlayerCount: {PhotonNetwork.CurrentRoom.PlayerCount}");

        foreach (var player in PhotonNetwork.CurrentRoom.Players)
        {
            Debug.Log($"PlayerName: {player.Value.NickName},{player.Value.ActorNumber}");
        }
    }

    private void CreatePlayer()
    {
        Vector3 pos = new Vector3(-40f, 0f, -15f);
        Vector3 randPos = pos + Random.insideUnitSphere * 5;
        randPos.y = 0;

        _networkPlayer = PhotonNetwork.Instantiate("Player/Origin", randPos, Quaternion.identity);
    } 

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log($"OnJoinRoomFailed: {returnCode}:{message}");
        InitRoom();
    }

    public override void OnPlayerEnteredRoom(Player player)
    {
        Debug.Log($"New player Entered: {player.NickName},{player.ActorNumber}");
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.Destroy(_networkPlayer);
    }
}