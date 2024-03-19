using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public static Manager Instance;

    public float money = 0f;

    public float quota;

    public float insanity = 0f;

    public float night = 0;

    public int kills = 0;
    private GameObject[] mainSceneObjects;

    public float nightLength = 240f;
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
        newNight();
        DontDestroyOnLoad(gameObject);
    }
    public void newNight()
    {
        money -= quota;
        num.pay = money;
        night++;
        quota = 300 + (night * 100);
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if (Time.timeSinceLevelLoad > nightLength)
        {
            Time.timeScale = 0f;
            
            //finish night and 
        }
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
