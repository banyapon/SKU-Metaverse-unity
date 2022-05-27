using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class GameManager : MonoBehaviourPun
{
    // DEBUG
    public InputField nickName;
    public Button btn1;
    public Button btn2;

    [Header("Player Settings")]
    public float sensitivity = 1f;
    public float moveSpeed = 20f;
    public float gravity = -9.8f;
    public float jumpPower = 2f;
    public int maxJumpCount = 1;

    [Header("CharacterController Settings")]
    public float slopeLimit = 45f;
    public float stepOffset = 0.3f;
    public float skinWidth = 0.08f;
    public float minMoveDistance = 0.001f;
    public float radius = 0.23f;
    public float height = 1.8f;
    public Vector3 center = new Vector3(0f, 0.9f, 0f);

    [Header("Animator Settings")]
    public RuntimeAnimatorController runtimeAnimatorController;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
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
    }

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;

        SoundManager.Instance.login_BGM();

        btn1.onClick.AddListener(() => {
            btn2.gameObject.SetActive(true);
        });

        btn2.onClick.AddListener(() => {
            PhotonNetwork.NickName = nickName.text;
            NetworkManager.Instance.ConnectToServer();
        });
    }
}
