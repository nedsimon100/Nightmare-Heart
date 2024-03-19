using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{

    public static Manager Instance;


    public float money = 0f;

    public float quota;

    public float insanity = 0f;

    public float night = 1;

    public int kills = 0;

    public bool gameOver=false;

    private GameObject[] mainSceneObjects;

    public GameObject endOfNightScreen;
    public GameObject UIScreen;

    public float nightLength = 100f;
    // Start is called before the first frame update

    

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        quota = 300 + (night * 100);

        Time.timeScale = 1;
        DontDestroyOnLoad(this.gameObject);
    }
    public void endOfNight()
    {
        Time.timeScale = 0;
        
        if (SceneManager.GetSceneByBuildIndex(1).isLoaded)
        {
            gameOver = true;
            UnLoadSurgery();
        }
        
        FindFirstObjectByType<UI>().nightEnd();
    }
    public void newNight()
    {
        


        SceneManager.LoadScene(0);
        txt.n = txt.n + 1;
        money -= quota;
        night++;
        quota = 300 + (night * 100);
    }

    public void restart()
    {
        
        SceneManager.LoadScene(0);

        money = 0f;

        insanity = 0f;

        night = 1;

        kills = 0;

        gameOver = false;

    }
    private void Update()
    {
        updateTime();
    }
    public void updateTime()
    {
        
        if (Time.timeSinceLevelLoad > nightLength)
        {
            Time.timeScale = 0f;
            endOfNight();
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
        
        

        mainSceneObjects = SceneManager.GetSceneAt(0).GetRootGameObjects();
        foreach (GameObject obj in mainSceneObjects)
        {
            obj.SetActive(true);
        }

        SceneManager.UnloadSceneAsync(1);

    }

}
