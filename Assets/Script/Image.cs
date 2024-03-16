using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;
using System.IO;
using UnityEngine.UI;

public class Image : MonoBehaviour
{
    public string FileName;
    public RenderTexture RT;
    public Texture2D TD;

    void getImage()
    {
        TD = new Texture2D(RT.width, RT.height, TextureFormat.ARGB32, false);
        RenderTexture.active = RT;
        TD.ReadPixels(new Rect(0,0,RT.width, RT.height), 0,0);
        TD.Apply();
        string path = Application.persistentDataPath + "/" + FileName + ".png";
        byte[] bytes = TD.EncodeToPNG();
        File.WriteAllBytes(path, bytes);
    }

    void SetImage()
    {
        TD = new Texture2D(RT.width, RT.height);
        string Path = Application.persistentDataPath + "/" + FileName + ".png";
        byte[] by = File.ReadAllBytes(Path);
        TD.LoadImage(by);
        TD.Apply();
    }

    IEnumerator Process()
    {
        getImage();
        yield return new WaitForSeconds(0.1f);
        SetImage();
        yield return new WaitForSeconds(0.3f);
    }

    void Start()
    {
        StartCoroutine(Process());
    }
}
