using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCspawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float Rate = 5f;
    [SerializeField] public float Rates = 10f;
    [SerializeField] public float Rating = 15f;
    [SerializeField] public float Rater = 20f;
    [SerializeField] public GameObject[] pre;
    [SerializeField] public GameObject[] pref;
    [SerializeField] public GameObject[] prefa;
    [SerializeField] public GameObject[] prefab;
    [SerializeField] private bool can = true;

    void Start()
    {
        if (num.diff >= 1)
        {
            StartCoroutine(Spawner());
        }
        if (num.diff >= 2)
        {
            StartCoroutine(Spawn());
        }
        if (num.diff >= 3)
        {
            StartCoroutine(Spawning());
        }
        if (num.diff >= 4)
        {
            StartCoroutine(Spawns());
        }
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(Rate);
        while (can)
        {
            yield return new WaitForSeconds(Random.Range(0f,5f)); // so they dont all spawn simultaniously
            int rand = Random.Range(0, pre.Length);

            GameObject clone = (GameObject)Instantiate(pre[rand], transform.position, Quaternion.identity);
            clone.tag = "NPC";
            yield return wait;
        }
    }
    private IEnumerator Spawn()
    {
        WaitForSeconds wait = new WaitForSeconds(Rates);
        while (can)
        {
            yield return new WaitForSeconds(Random.Range(0f, 10f)); // so they dont all spawn simultaniously
            int rand = Random.Range(0, pre.Length);

            GameObject clone = (GameObject)Instantiate(pref[rand], transform.position, Quaternion.identity);
            clone.tag = "Police";
            yield return wait;
        }
    }
    private IEnumerator Spawning()
    {
        WaitForSeconds wait = new WaitForSeconds(Rating);
        while (can)
        {
            yield return new WaitForSeconds(Random.Range(0f, 15f)); // so they dont all spawn simultaniously
            int rand = Random.Range(0, pre.Length);

            GameObject clone = (GameObject)Instantiate(prefa[rand], transform.position, Quaternion.identity);
            clone.tag = "Mafia";
            yield return wait;
        }
    }
    private IEnumerator Spawns()
    {
        WaitForSeconds wait = new WaitForSeconds(Rater);
        while (can)
        {
            yield return new WaitForSeconds(Random.Range(0f, 20f)); // so they dont all spawn simultaniously
            int rand = Random.Range(0, pre.Length);

            GameObject clone = (GameObject)Instantiate(prefab[rand], transform.position, Quaternion.identity);
            clone.tag = "Dead";
            yield return wait;
        }
    }
}
