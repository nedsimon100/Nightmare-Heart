using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCspawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float Rate = 2.5f;
    [SerializeField] public GameObject[] pre;
    [SerializeField] private bool can = true;

    void Start()
    {
            StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(Rate);
        while (can)
        {
            yield return new WaitForSeconds(Random.Range(0f,5f)); // so they dont all spawn simultaniously
            int rand = Random.Range(0, pre.Length);

            GameObject clone = (GameObject)Instantiate(pre[rand], transform.position, Quaternion.identity);
            yield return wait;
            //clone.tag = "Enemy";
        }
    }
}
