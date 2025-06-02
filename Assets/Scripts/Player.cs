using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float inputH;
    [SerializeField] private float movementspeed;
    [SerializeField] private float jumpspeed;
    public SpriteRenderer spriterenderer;
    private Animator anim;
    private int scrollscollected;
    public AudioSource audiosource_jump;
    public AudioSource audiosource_gameover;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        scrollscollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        attack();
    }
    private void attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("attack");
        }
    }
    

    private void movement()
    {
        inputH = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputH * movementspeed, rb.velocity.y);

        if ((Input.GetKeyDown(KeyCode.Space) || (Input.GetKey("w")) || (Input.GetKey("up"))) && groundcheck.touchingtheground )
        {
            rb.AddForce(Vector2.up * jumpspeed, ForceMode2D.Impulse);
        }
        if (inputH != 0)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
        if ((Input.GetKey("d")) || (Input.GetKey("right")))
        {
            spriterenderer.flipX = false;
        }
        if ((Input.GetKey("a")) || (Input.GetKey("left")))
        {
            spriterenderer.flipX = true;
        }
        if (((Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.Space))) && groundcheck.touchingtheground)
        {
            anim.SetBool("jump", true);
            audiosource_jump.Play();
        }
        else
        {
            anim.SetBool("jump", false);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            anim.SetBool("hit", true);

        }
    }
}
