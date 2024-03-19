using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Restart : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Over");
        }
        string ui = "Money Gained = " + num.pay + "\n" + "Insane Level = " + num.sane + "\n" + "Night Lived = " + num.diff + "\n" + 
            "Kills = " + num.kill;
        scoreText.text = ui;
        num.pay = 0;
        num.sane = 0;
        num.diff = 0;
        num.kill = 0;
    }
}
