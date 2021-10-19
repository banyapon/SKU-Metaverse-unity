using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectChar : MonoBehaviour
{
    public Character Character;

    private void OnMouseUpAsButton()
    {
        ChoiceCharacter.instance.currentCharacter = Character;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Main");
    }
}