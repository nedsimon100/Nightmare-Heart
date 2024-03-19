using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
    public Vector2 waypoint;
    public float huntRange = 8f;
    public float speed = 2f;

    public Vector2[] rayDirect;

    public Rigidbody2D rb;

    Vector2 obsticalAvoid = Vector2.zero;
    void Start()
    {
        StartCoroutine(newwaypointtimer());
    }

    IEnumerator newwaypointtimer()
    {
        while (true)
        {
            waypoint = new Vector2(Random.Range(-10f, 14f), Random.Range(-25f, 26f));
            yield return new WaitForSeconds(5f);
        }
    }
    void Update()
    {

        obsticalAvoid = Vector2.zero;
        huntRange = (FindAnyObjectByType<Manager>().kills)+5;
        if ((FindFirstObjectByType<PlayerController>().gameObject.transform.position - this.transform.position).magnitude < huntRange)
        {
            waypoint = FindFirstObjectByType<PlayerController>().gameObject.transform.position;
        }
        else
        {
            obsticles();
        }
        
        move();
        
    }

    private void obsticles()
    {
        rayDirect = new Vector2[8];
        rayDirect[1] = (-transform.right).normalized;
        rayDirect[2] = (-transform.right + transform.up).normalized;
        rayDirect[3] = (transform.up).normalized;
        rayDirect[4] = (transform.right + transform.up).normalized;
        rayDirect[5] = (transform.right).normalized;
        rayDirect[6] = (transform.right - transform.up).normalized;
        rayDirect[7] = (-transform.up).normalized;
        rayDirect[6] = (-transform.right - transform.up).normalized;

        RaycastHit2D hit;

        foreach (Vector2 ray in rayDirect)
        {

            hit = Physics2D.Raycast(transform.position, ray);
            if (hit.distance < 5)
            {
                obsticalAvoid += (5 - hit.distance) * -ray;
            }
        }
    }

    private void move()
    {
        
        
        // + (new Vector3(obsticalAvoid.x, obsticalAvoid.y, 0)/4)

        rb.velocity = ((new Vector3(waypoint.x, waypoint.y, 0) - transform.position).normalized + (new Vector3(obsticalAvoid.x, obsticalAvoid.y, 0)/ 7)) * (speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == FindFirstObjectByType<PlayerController>().gameObject)
        {
            FindAnyObjectByType<Manager>().gameOver = true;
            FindAnyObjectByType<Manager>().endOfNight();
        }
    }
}
