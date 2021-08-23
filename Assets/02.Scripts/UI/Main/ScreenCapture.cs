using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class ScreenCapture : MonoBehaviour
{
    private string m_Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "\\sku_miso" + "\\";
    private string m_FilePrefix = "sku_miso_";
    private string m_FilePath;

    //솔
    int count_ = 0;
    public GameObject Stamp2_;

    public void OnClickButton()
    {
        m_FilePath = m_Path + m_FilePrefix + DateTime.Now.ToString("MMdd_hhmmss") + ".jpg";
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\sku_miso");
        StartCoroutine(SaveScreeJpg(m_FilePath));

        //솔
        count_ = 1;
        if (count_ == 1)
        {
            Color SColor = Stamp2_.GetComponent<Image>().color;
            SColor.a = 1f;
            Stamp2_.GetComponent<Image>().color = SColor;
        }
    }

    IEnumerator SaveScreeJpg(string filePath)
    {
        yield return new WaitForEndOfFrame();

        Texture2D texture = new Texture2D(600, 1000);
        texture.ReadPixels(new Rect((Screen.width / 2 - 300), (Screen.height / 2 - 500), 600, 1000), 0, 0);
        texture.Apply();
        byte[] bytes = texture.EncodeToJPG();
        File.WriteAllBytes(filePath, bytes);
        DestroyImmediate(texture);
    }
}
