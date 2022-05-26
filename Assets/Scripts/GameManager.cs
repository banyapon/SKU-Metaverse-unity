using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Lobby;
    public GameObject InputField;
    public GameObject toggleGroup;

    private string toggleStr = "<color=#3232FF>(학부생)</color> ";

    public Text NameText;
    public Text User;

    public static bool IsToggle1;

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

        #if UNITY_ANDROID || UNITY_IOS
            Application.targetFrameRate = 30;
        #elif UNITY_EDITOR || UNITY_STANDALONE
            Application.targetFrameRate = 60;
        #endif
    }

    void Start()
    {
        SoundManager.Instance.login_BGM();
        // PlayerPrefs.DeleteKey("Name");
    }

    public void CheckToggle1()
    {
        toggleStr = "<color=#FF8C00>(교직원)</color> ";
        IsToggle1 = true;
    }
    public void CheckToggle2()
    {
        toggleStr = "<color=#3232FF>(학부생)</color> ";
    }
    public void CheckToggle3()
    {
        toggleStr = "<color=#225555>(게스트)</color> ";
    }

    public void onNameSaveClick()
    {
        if(NameText.text == "")
        {
            Debug.Log("1 :" + NameText.text);
            User.text = "<color=#ff0000>이름을 입력해주세요!</color>";
        }
        else
        {
            Debug.Log("2 :" +  toggleStr + NameText.text);
            // PlayerPrefs.SetString("Name", toggleStr + NameText.text);
            InputField.SetActive(false);
            toggleGroup.SetActive(false);
            Lobby.SetActive(true);
        }
    }
}
