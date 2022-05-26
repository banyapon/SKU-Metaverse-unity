using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject uiController;
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UIManager();
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

        SetUIController();
    }

    void SetUIController()
    {
        if (uiController == null) return;
        #if UNITY_ANDROID || UNITY_IOS
            uiController.SetActive(true);
        #elif UNITY_EDITOR || UNITY_STANDALONE
            // TODO: Test code, Check platform
            uiController.SetActive(true);
        #endif
    }
}
