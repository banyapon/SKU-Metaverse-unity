using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    MaleA, MaleB, MaleC, MaleD, MaleE, MaleF, MaleG, MaleH, MaleI, MaleJ, MaleK, MaleL, MaleM, MaleN, MaleO,
    FeMaleA, FeMaleB, FeMaleC, FeMaleD, FeMaleE, FeMaleF, FeMaleG, FeMaleH, FeMaleI, FeMaleJ, FeMaleK, FeMaleL, FeMaleM, FeMaleN, FeMaleO
}

public class ChoiceCharacter : MonoBehaviour
{
    public static ChoiceCharacter instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;
}