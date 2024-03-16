using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Behavior : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;

    Vector2 WayPoint;
    // Start is called before the first frame update
    void Start()
    {
        New();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, WayPoint, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, WayPoint) < range )
        {
            New();
        }
    }

    void New()
    {
        WayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
}
