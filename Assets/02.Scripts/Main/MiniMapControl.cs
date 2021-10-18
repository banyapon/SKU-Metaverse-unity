using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapControl : MonoBehaviour
{
    public GameObject MiniMap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T) && MiniMap.activeSelf == false)
        {
            MiniMap.SetActive(true);
        }
        else
            MiniMap.SetActive(false);
    }
}
