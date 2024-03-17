using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Num : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int diff;
    public static int lore;
    public static float paid;
    // Update is called once per frame

    void Start()
    {
        diff = 0;
        paid = 0;
    }

    void Update()
    {
        string ui = "Wanted Level: " + diff;
        scoreText.text = ui;
    }
}
