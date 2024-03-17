using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public static Manager Instance;

    public float money = 0f;

    public float insanity = 0f;

    private GameObject[] mainSceneObjects;

    // Start is called before the first frame update

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void LoadSurgery()
    {
    
        mainSceneObjects = SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (GameObject obj in mainSceneObjects)
        {
            obj.SetActive(false);
        }

        
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public void UnLoadSurgery()
    {
        
        SceneManager.UnloadSceneAsync(1);

        mainSceneObjects = SceneManager.GetSceneAt(0).GetRootGameObjects();
        foreach (GameObject obj in mainSceneObjects)
        {
            obj.SetActive(true);
        }

        

    }

}
