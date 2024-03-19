using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject endOfNightScreen;
    public GameObject UIScreen;

    public TextMeshProUGUI timeDisplay;

    public TextMeshProUGUI[] moneyDisplay;

    public TextMeshProUGUI[] QuotaDisplay;

    public TextMeshProUGUI nighttext;

    public GameObject GameOverScreen;

    public GameObject mainUI;

    public GameObject nextnightButton;
    public GameObject startScreen;

    public float time;

    public TextMeshProUGUI profitTxt;

    public void startGame()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1;
        mainUI.SetActive(true);
    }

    public void newRun()
    {
        startScreen.SetActive(true);
        Time.timeScale = 0;
        mainUI.SetActive(false);
    }
    void Start()
    {
        if(FindFirstObjectByType<Manager>().night == 1)
        {
            startScreen.SetActive(true);
            Time.timeScale = 0;
            mainUI.SetActive(false);
        }
        else
        {
            startScreen.SetActive(false);
            Time.timeScale = 1;
            mainUI.SetActive(true);
        }
        
        foreach(TextMeshProUGUI quota in QuotaDisplay)
        {
            quota.text = "£" + FindFirstObjectByType<Manager>().quota.ToString();
        }
        UpdateMoney();
    }

    // Update is called once per frame
    void Update()
    {
        if(startScreen.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        UpdateClock();
    }
    public void UpdateMoney()
    {
        foreach (TextMeshProUGUI money in moneyDisplay)
        {
            money.text = FindFirstObjectByType<Manager>().money.ToString();
        }

    }
    void UpdateClock()
    {
        time = (Time.timeSinceLevelLoad / FindFirstObjectByType<Manager>().nightLength) * 360f;//00:00 to 06:00 speed changes automaticaly to fit night length
        if(Mathf.FloorToInt(time % 60) >= 10)
        {
            timeDisplay.text = "0" + Mathf.FloorToInt(time / 60).ToString() + ":" + Mathf.FloorToInt(time % 60).ToString();
        }
        else
        {
            timeDisplay.text = "0" + Mathf.FloorToInt(time / 60).ToString() + ":0" + Mathf.FloorToInt(time % 60).ToString();
        }
        
    }

    public void nightEnd() 
    {
        UIScreen.SetActive(false);
        endOfNightScreen.SetActive(true);
        profitTxt.text = (FindFirstObjectByType<Manager>().money - FindFirstObjectByType<Manager>().quota).ToString();
        nighttext.text = FindFirstObjectByType<Manager>().night.ToString();
        if (FindFirstObjectByType<Manager>().money < FindFirstObjectByType<Manager>().quota || FindFirstObjectByType<Manager>().gameOver)
        {

            mafiaEnd();
        }
        else
        {
            nextnightButton.SetActive(true);
            
        }
    }
    public void mafiaEnd()
    {
        GameOverScreen.SetActive(true);
    }
    public void restart()
    {
        FindFirstObjectByType<Manager>().restart();
    }
    public void newNight()
    {
        FindFirstObjectByType<Manager>().newNight();
    }
}
