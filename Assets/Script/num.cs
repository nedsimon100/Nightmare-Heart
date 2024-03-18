using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class num : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int diff;
    public static float pay;
    public static float sane;
    public static int kill;
    public static int day;
    public static int lore;
    // Update is called once per frame

    void Start()
    {
        diff = 0;
    }

    void Update()
    {
        string ui = "Wanted Level: " + diff;
        scoreText.text = ui;
    }
}
