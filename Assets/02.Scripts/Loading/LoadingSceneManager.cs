using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneManager : MonoBehaviour
{
    public Slider slider;
    public string SceneName;

    private float time;


    void Start()
    {
        StartCoroutine(LoadAsynSceneCoroutine());
        
    }

    IEnumerator LoadAsynSceneCoroutine()
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneName);

        operation.allowSceneActivation = false;



        while (!operation.isDone)
        {

            slider.value = operation.progress;

            operation.allowSceneActivation = true;

            yield return null;
        }

    }
}
