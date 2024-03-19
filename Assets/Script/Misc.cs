using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Misc : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    [SerializeField] public GameObject red;

    // Update is called once per frame
    void Update()
    {
        int rand = Random.Range(10000000, 1000000000);
        string ui = "Debt of \n £" + rand;
        scoreText.text = ui;
        if (num.diff >= 5)
        {
            red.SetActive(true);
        }
    }
}
