using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemytr : MonoBehaviour
{
    public float begin;
    public float dist = 1;
    public float speed = 5;
    public int dir;
    private Vector2 movement;
    private SpriteRenderer sb;
    [SerializeField] float health, maxHealth = 3f;
    private float damageAmount = 5;
    private Animator anim;


    //[SerializeField]




    public bool Flip { get; private set; }



    void Start()
    {
        sb = GetComponent<SpriteRenderer>();
        begin = transform.position.x;
        dir = 1;
        health = maxHealth;

    }


    void FixedUpdate()
    {

        // you should'nt need a non-kinetic rigidbody attached for this simple movement!!!
        if (transform.position.x > begin + dist)
        {
            dir = -1;
            sb.flipX = false;

        }
        else
        {
            if (transform.position.x < begin - dist)
            {
                dir = 1;
                sb.flipX = true;
            }
        }
        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed * dir,
                                              transform.position.y,
                                              transform.position.z);
        transform.localScale = new Vector2(-1.855469f, 1.81125f);
        transform.localScale = new Vector2(-1.855469f, 1.81125f);


        if (health <= 0)
        {
            Destroy(gameObject);
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("The Collider is working");
        if (other.CompareTag("Attack"))
        {
            health -= damageAmount;
            Debug.Log("The tag is working");
        }
    }






}
