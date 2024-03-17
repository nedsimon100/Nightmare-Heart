using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    [SerializeField] public GameObject b;
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Police")
        {
            SceneManager.LoadScene("Police Ending");
        }
        else if (coll.gameObject.tag == "Mafia")
        {
            SceneManager.LoadScene("Mafia Ending");
        }
        else if (coll.gameObject.tag == "Dead")
        {
            SceneManager.LoadScene("True");
        }
        else if (coll.gameObject.tag == "NPC")
        {
            b.SetActive(true);
        }
        else
        {
            b.SetActive(false);
        }
    }
}
