using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class txt : MonoBehaviour
{
    public static int n;
    string pc = Environment.MachineName;
    string name = Environment.UserName;
    private string times;
    private string dates;

    void T()
    {
        string path = Application.dataPath + "/Letter.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Howady Pal, \n\n");
        }

        string content = "You owe us alot of money for the protection \n\n" +
            "We want our money now & but we know it too much \n\n" +
            "If you dont pay then you will die \n\n" +
            "So get our money now \n\n" +
            "If you dont have a job we will give one \n\n" +
            "Yours skills will be useful in black market organs \n\n" +
            "Hearts are in so get to it \n\n" +
            "The Police will be after you \n\n" +
            "So dont get caught \n\n" +
            "Sinceriy, Mafia. \n\n";

        File.AppendAllText(path, content);
    }

    void T1()
    {
        string path = Application.dataPath + "/Journal.txt";
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

    void T2()
    {
        string path = Application.dataPath + "/Log.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Great Day today, \n\n");
        }

        string content = "Breakfast was great today with extra servings \n\n" +
            "Lunch was even better with luxury food \n\n" +
            "Got lots of coupons today for different stuff \n\n" +
            "I was 100th customer at a store & got free item \n\n" +
            "Tonight is going to be fun with fireworks\n\n" +
            "Dinner was also great \n\n" +
            "My friends gave some collector editions items \n\n" +
            "My boss gave me a present \n\n" +
            "Lets hope it ever ends. \n\n";

        File.AppendAllText(path, content);
    }

    void T3()
    {
        string path = Application.dataPath + "/Entry.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Work is annoying \n\n");
        }

        string content = "Boss gives extra work \n\n" +
            "The client is so aggrevating with their demands & attitude is rude \n\n" +
            "Boss ordered me to make a speech for Jane \n\n" +
            "I need to complete my presentation by tomorrow \n\n" +
            "I also need to manage the new recruits during next week \n\n" +
            "Collegues are givign their tasks \n\n" +
            "I had work overtime with n break \n\n" +
            "I need a break. \n\n";

        File.AppendAllText(path, content);
    }

    void T4()
    {
        string path = Application.dataPath + "/Memos.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Worst Day today \n\n");
        }

        string content = "I feel this uneasiness today \n\n" +
            "The People are looking at wired & staying away \n\n" +
            "Food was served cold \n\n" +
            "Got scammed on a product today \n\n" +
            "Police are asking me questions \n\n" +
            "Boss gave a rush of work & telling me off \n\n" +
            "Lets hope tomorrow can be better. \n\n";

        File.AppendAllText(path, content);
    }

    void T5()
    {
        string path = Application.dataPath + "/I saw them.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "I hear them \n\n");
        }

        string content = "I feel them \n\n" +
            "I hear them \n\n" +
            "I smeel them \n\n" +
            "They are screaming at me \n\n" +
            "They continue to destroy me \n\n" +
            "They wont let go. \n\n";

        File.AppendAllText(path, content);
    }

    void T6()
    {
        string path = Application.dataPath + "/Theraphy.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "My theraphy doesn't help \n\n");
        }

        string content = "They getting louder \n\n" +
            "It wont stop \n\n" +
            "I was deterined by police \n\n" +
            "I got fired my job \n\n" +
            "I stop going. \n\n";

        File.AppendAllText(path, content);
    }

    void T7()
    {
        string path = Application.dataPath + "/God.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "May God help them \n\n");
        }

        string content = "I deserve the pain \n\n" +
            "I Deserve hell \n\n" +
            "They deserve heaven \n\n" +
            "I regret it. \n\n";

        File.AppendAllText(path, content);
    }

    void T8()
    {
        string path = Application.dataPath + "/I see you.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "What is this & who are you & are you the cause of this \n\n");
        }

        string content = "Is my world all fiction ... \n\n" +
            "Why did you ruin my life for what this misery \n\n" +
            "Please stop. \n\n";

        File.AppendAllText(path, content);
    }

    void T9()
    {
        DateTime now = DateTime.Now;
        times = now.ToString("hh:mm:ss");
        dates = now.ToString("dd:MM:yyyy");
        string path = Application.dataPath + "/I Can Do it.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "I see the code & my world is a game \n\n");
        }

        string content = "But I do stuff in change \n\n" +
            "Here what I can do \n\n" + times + "\n" + dates;

        File.AppendAllText(path, content);
    }

    void T10()
    {
        string path = Application.dataPath + "/Please Stop.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "I dont want to do this anymore \n\n");
        }

        string content = "Please" + name + "Stop this & end my suffering on this " + pc;

        File.AppendAllText(path, content);
    }

    // Start is called before the first frame update
    void Start()
    {
        n = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(n == 0)
        {
            T();
        }
        else if (n == 1)
        {
            T1();
        }
        else if (n == 2)
        {
            T2();
        }
        else if (n == 3)
        {
            T3();
        }
        else if (n == 4)
        {
            T4();
        }
        else if (n == 5)
        {
            T5();
        }
        else if (n == 6)
        {
            T6();
        }
        else if (n == 7)
        {
            T7();
        }
        else if (n == 8)
        {
            T8();
        }
        else if (n == 9)
        {
            T9();
        }
        else if (n == 10)
        {
            T10();
        }
    }
}
