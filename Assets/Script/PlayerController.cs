using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public GameObject corpse;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        float speed = 4.0f;
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"),
       Input.GetAxis("Vertical")).normalized * speed;
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("xspeed", rb.velocity.x);
        anim.SetFloat("yspeed", rb.velocity.y);
        if (rb.velocity.magnitude < 0.01)
            anim.speed = 0.0f;
        else
            anim.speed = 1.0f;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(corpse, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            FindFirstObjectByType<Manager>().LoadSurgery();
        }
    }
}