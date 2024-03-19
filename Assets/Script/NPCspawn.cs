using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCspawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float Rate = 5f;

    [SerializeField] public GameObject[] prefabs;

    public int amountToSpawn = 1;


    void Start()
    {
        if(prefabs[0].tag == "Police")
        {
            amountToSpawn = Mathf.FloorToInt(FindFirstObjectByType<Manager>().night);
        }

            StartCoroutine(Spawner());
        

    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(Rate);
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0f,5f)); // so they dont all spawn simultaniously
            
            for(int i =0; i < amountToSpawn; i++)
            {
                int rand = Random.Range(0, prefabs.Length);

                GameObject clone = (GameObject)Instantiate(prefabs[rand], transform.position, Quaternion.identity);
            }

            yield return wait;
        }
    }

}
