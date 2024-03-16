using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCspawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float Rate = 2.5f;
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
            yield return wait;
            int rand = Random.Range(0, pre.Length);
            GameObject clone = (GameObject)Instantiate(pre[rand], transform.position, Quaternion.identity);
            //clone.tag = "Enemy";
        }
    }
}
