using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceCharacter : MonoBehaviour
{
    public string MaleA = "MaleA";
    public string MaleB = "MaleB";
    public string MaleC = "MaleC";
    public string MaleD = "MaleD";
    public string MaleE = "MaleE";
    public string MaleF = "MaleF";
    public string MaleG = "MaleG";
    public string MaleH = "MaleH";
    public string MaleI = "MaleI";
    public string MaleJ = "MaleJ";
    public string MaleK = "MaleK";
    public string MaleL = "MaleL";
    public string MaleM = "MaleM";
    public string MaleN = "MaleN";
    public string MaleO = "MaleO";
    public string FemaleA = "FemaleA";
    public string FemaleB = "FemaleB";
    public string FemaleC = "FemaleC";
    public string FemaleD = "FemaleD";
    public string FemaleE = "FemaleE";
    public string FemaleF = "FemaleF";
    public string FemaleG = "FemaleG";
    public string FemaleH = "FemaleH";
    public string FemaleI = "FemaleI";
    public string FemaleJ = "FemaleJ";
    public string FemaleK = "FemaleK";
    public string FemaleL = "FemaleL";
    public string FemaleM = "FemaleM";
    public string FemaleN = "FemaleN";
    public string FemaleO = "FemaleO";

    public static string netPlayer;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void funcMaleA()
    {
        netPlayer = MaleA;
        Debug.Log(netPlayer);
        NetworkManager.Instance.ConnectToServer();
    }

    public void funcMaleB()
    {
        netPlayer = MaleB;
        Debug.Log(netPlayer);
    }

    public void funcMaleC()
    {
        netPlayer = MaleC;
        Debug.Log(netPlayer);
    }

    public void funcMaleD()
    {
        netPlayer = MaleD;
        Debug.Log(netPlayer);
    }

    public void funcMaleE()
    {
        netPlayer = MaleE;
        Debug.Log(netPlayer);
    }

    public void funcMaleF()
    {
        netPlayer = MaleF;
        Debug.Log(netPlayer);
    }

    public void funcMaleG()
    {
        netPlayer = MaleG;
        Debug.Log(netPlayer);
    }

    public void funcMaleH()
    {
        netPlayer = MaleH;
        Debug.Log(netPlayer);
    }

    public void funcMaleI()
    {
        netPlayer = MaleI;
        Debug.Log(netPlayer);
    }

    public void funcMaleJ()
    {
        netPlayer = MaleJ;
        Debug.Log(netPlayer);
    }

    public void funcMaleK()
    {
        netPlayer = MaleK;
        Debug.Log(netPlayer);
    }

    public void funcMaleL()
    {
        netPlayer = MaleL;
        Debug.Log(netPlayer);
    }

    public void funcMaleM()
    {
        netPlayer = MaleM;
        Debug.Log(netPlayer);
    }

    public void funcMaleN()
    {
        netPlayer = MaleN;
        Debug.Log(netPlayer);
    }

    public void funcMaleO()
    {
        netPlayer = MaleO;
        Debug.Log(netPlayer);
    }

    public void funcFemaleA()
    {
        netPlayer = FemaleA;
        Debug.Log(netPlayer);
    }

    public void funcFemaleB()
    {
        netPlayer = FemaleB;
        Debug.Log(netPlayer);
    }

    public void funcFemaleC()
    {
        netPlayer = FemaleC;
        Debug.Log(netPlayer);
    }

    public void funcFemaleD()
    {
        netPlayer = FemaleD;
        Debug.Log(netPlayer);
    }

    public void funcFemaleE()
    {
        netPlayer = FemaleE;
        Debug.Log(netPlayer);
    }

    public void funcFemaleF()
    {
        netPlayer = FemaleF;
        Debug.Log(netPlayer);
    }

    public void funcFemaleG()
    {
        netPlayer = FemaleG;
        Debug.Log(netPlayer);
    }

    public void funcFemaleH()
    {
        netPlayer = FemaleH;
        Debug.Log(netPlayer);
    }

    public void funcFemaleI()
    {
        netPlayer = FemaleI;
        Debug.Log(netPlayer);
    }

    public void funcFemaleJ()
    {
        netPlayer = FemaleJ;
        Debug.Log(netPlayer);
    }

    public void funcFemaleK()
    {
        netPlayer = FemaleK;
        Debug.Log(netPlayer);
    }

    public void funcFemaleL()
    {
        netPlayer = FemaleL;
        Debug.Log(netPlayer);
    }

    public void funcFemaleM()
    {
        netPlayer = FemaleM;
        Debug.Log(netPlayer);
    }

    public void funcFemaleN()
    {
        netPlayer = FemaleN;
        Debug.Log(netPlayer);
    }

    public void funcFemaleO()
    {
        netPlayer = FemaleO;
        Debug.Log(netPlayer);
    }
}