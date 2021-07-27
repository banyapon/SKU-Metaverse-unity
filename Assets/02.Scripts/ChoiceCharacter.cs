using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceCharacter : MonoBehaviour
{
    public string MaleA = "MaleA";
    public string MaleB = "MaleB";
    public string MaleC = "MaleC";
    public string MaleD = "MaleD";
    public string MaleE = "MaleE";
    public string FemaleA = "FemaleA";
    public string FemaleB = "FemaleB";
    public string FemaleC = "FemaleC";
    public string FemaleD = "FemaleD";
    public string FemaleE = "FemaleE";

    private NetworkPlayerSpawner netPlayer;

    void Start()
    {
        netPlayer = FindObjectOfType<NetworkPlayerSpawner>();
    }

    public void funcMaleA()
    {
        netPlayer.choiceCharacter = MaleA;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcMaleB()
    {
        netPlayer.choiceCharacter = MaleB;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcMaleC()
    {
        netPlayer.choiceCharacter = MaleC;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcMaleD()
    {
        netPlayer.choiceCharacter = MaleD;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcMaleE()
    {
        netPlayer.choiceCharacter = MaleE;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcFemaleA()
    {
        netPlayer.choiceCharacter = FemaleA;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcFemaleB()
    {
        netPlayer.choiceCharacter = FemaleB;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcFemaleC()
    {
        netPlayer.choiceCharacter = FemaleC;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcFemaleD()
    {
        netPlayer.choiceCharacter = FemaleD;
        Debug.Log(netPlayer.choiceCharacter);
    }

    public void funcFemaleE()
    {
        netPlayer.choiceCharacter = FemaleE;
        Debug.Log(netPlayer.choiceCharacter);
    }
}