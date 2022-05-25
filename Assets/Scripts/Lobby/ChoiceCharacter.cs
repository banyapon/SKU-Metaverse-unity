using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceCharacter : MonoBehaviour
{
    public string MaleA = "MaleA";
    public string MaleB = "MaleB";
    public string MaleC = "MaleC";

    public static string netPlayer;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void funcMaleA()
    {
        netPlayer = MaleA;
        NetworkManager.Instance.ConnectToServer();
    }

    public void funcMaleB()
    {
        netPlayer = MaleB;
        NetworkManager.Instance.ConnectToServer();
    }

    public void funcMaleC()
    {
        netPlayer = MaleC;
        NetworkManager.Instance.ConnectToServer();
    }
}