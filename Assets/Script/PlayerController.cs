using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public GameObject corpse;
    public Button KillButton;
    public GameObject npcToKill;

    public bool attackBool = false;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Time.timeScale = 1f;
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
        if(collision.gameObject.tag == "NPC")
        {
            KillButton.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space) || attackBool) 
            {
                Instantiate(corpse, collision.transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                FindFirstObjectByType<Manager>().LoadSurgery();
                attackBool = false;
            }
        }
        
    }
    public void attackBtn()
    {
        attackBool = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        KillButton.gameObject.SetActive(false);
    }
}