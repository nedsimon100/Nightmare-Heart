using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public void LoadScene(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
