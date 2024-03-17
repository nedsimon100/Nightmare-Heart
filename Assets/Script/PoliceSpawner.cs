using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float Rate = 20f;
    [SerializeField] public GameObject pre;
    [SerializeField] private bool can = true;

    void Start()
    {
        if (Num.diff >= 1)
        {
            for (int i = 0; i <= Num.diff - 1; i++)
            {
                StartCoroutine(Spawner());
            }
        }
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(Rate);
        while (can)
        {
            yield return wait;
            GameObject clone = (GameObject)Instantiate(pre, transform.position, Quaternion.identity);
            clone.tag = "Police";
        }
    }
}
