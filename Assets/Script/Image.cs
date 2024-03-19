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
    public GameObject RenderCamera;
    public RawImage RI;
    //public Texture2D TD;

    void getImage()
    {
        Texture2D texture = new Texture2D(RT.width, RT.height, TextureFormat.ARGB32, false);
        RenderTexture.active = RT;
        texture.ReadPixels(new Rect(0,0,RT.width, RT.height), 0,0);
        texture.Apply();
        string path = Application.persistentDataPath + "/" + FileName + ".png";
        byte[] bytes = texture.EncodeToPNG();
        File.WriteAllBytes(path, bytes);
    }

    void SetImage()
    {
        Texture2D texture2D = new Texture2D(RT.width, RT.height);
        string Path = Application.persistentDataPath + "/" + FileName + ".png";
        byte[] by = File.ReadAllBytes(Path);
        texture2D.LoadImage(by);
        texture2D.Apply();
    }

    IEnumerator Process()
    {
        RenderCamera.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        getImage();
        yield return new WaitForSeconds(0.01f);
        SetImage();
        yield return new WaitForSeconds(0.01f);
        RenderCamera.SetActive(false);
    }

    public void GetSet_btn()
    {
        StartCoroutine(Process());
    }
}
