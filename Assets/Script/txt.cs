using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class txt : MonoBehaviour
{

    void Createtxt()
    {
        string path = Application.dataPath + "/memos.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "What a beautiful day \n\n");
        }

        string content = "Everything the same & nothing else changes day by day \n\n" +
            "The Street are filled with people: going on their daily business \n\n" +
            "The Fresh Air that I gone accostomed with each waking moment \n\n" +
            "My Latte taste so good with 2 scopes of sugar & goes well with my brioche \n\n" +
            "Today Newspaper is filled with story of string of missing people, I wonder when the police are going to find them \n\n" +
            "But everyone goes about their daily business without issue \n\n" +
            "My time is up if I don't finish that report for the company the boss will have may head \n\n" +
            "I hear things are going well with the team & Jane is getting married next month, I am happy for her since it will bright ip her life \n\n" +
            "Note to Self get a gift for her before she leaves for Vegas but what to get for her flowers? Chocolate? Something expensive? IDK, I decide on it later \n\n"+
            "Lets hope tomorrow is as good as these days. \n\n";

        File.AppendAllText(path, content);
    }
    // Start is called before the first frame update
    void Start()
    {
        Createtxt();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
