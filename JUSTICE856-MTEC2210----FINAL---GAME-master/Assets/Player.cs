using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LayerMask ground;
    public float speed;
    public float jumpSpeed = 1;
    private Rigidbody2D rb;
    public string midjump = "n";
    private SpriteRenderer sr;
    private Animator anim;
    public GameObject attackHitbox;



    bool jumping;
    float xMove;

    public float distanceCheckAmount = 0.5f;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        DisableAttackCollider();

    }

    // Update is called once per frame
    void Update()
    {

        xMove = Input.GetAxisRaw("Horizontal");

        if (xMove != 0)
        {

            if (xMove < 0)

            {
                sr.flipX = true;
            }

        }
        else if (xMove < 0)

        {
            if (xMove < 0)
                sr.flipX = false;

        }
        else
        {
            anim.SetBool("Moving", false);

        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            anim.SetTrigger("Tornado");
        }
        
            if (Input.GetKeyDown(KeyCode.F))
            {
                anim.SetTrigger("Attack");
                EnableAttackCollider();


            }
            if ((Input.GetKeyDown(KeyCode.Space) && midjump == "n"))
            {
                anim.SetTrigger("Jump");
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 20, 0);
                midjump = "y";
            }

            if (GetComponent<Rigidbody2D>().velocity.y == 0)
                midjump = "n";

        }
        





        public void EnableAttackCollider()
        {
            attackHitbox.SetActive(true);
        }

        public void DisableAttackCollider()
        {
            attackHitbox.SetActive(false);
        }


        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Elevator"))
                transform.parent = null;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Elevator"))
                transform.parent = collision.transform;

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("EnemyBullet"))
            { Destroy(gameObject); }
        }
        
        

        private bool GroundCheck()
        {
            Collider2D col = GetComponent<Collider2D>();
            return Physics2D.Raycast(transform.position, Vector2.down, distanceCheckAmount, ground);

        }
        

        private void FixedUpdate()
        {

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
                transform.localScale = new Vector2(4.876955f, 3.121644f);

            }


            anim.SetBool("Moving", true);
            if (Input.GetKey(KeyCode.D))
            {

                transform.Translate(speed * Time.deltaTime, 0, 0);
                transform.localScale = new Vector2(-4.876955f, 3.121644f);
            }


            if (jumping == true)
            {

                rb.AddForce(Vector2.up * jumpSpeed * Time.deltaTime, ForceMode2D.Impulse);
                jumping = false;
            }
        
            
        

    }
    }








