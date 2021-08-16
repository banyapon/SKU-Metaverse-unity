using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ScreenCapture : MonoBehaviour
{
    private string m_Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "\\sku_miso" + "\\";
    private string m_FilePrefix = "sku_miso_";
    private string m_FilePath;

    public void OnClickButton()
    {
        m_FilePath = m_Path + m_FilePrefix + DateTime.Now.ToString("MMdd_hhmmss") + ".jpg";
        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\sku_miso");
        StartCoroutine(SaveScreeJpg(m_FilePath));
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
