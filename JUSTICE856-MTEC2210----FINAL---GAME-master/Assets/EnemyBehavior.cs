using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyBehavior : MonoBehaviour
{
    public float begin;
    public float dist = 5;
    public float speed = 5;
    public int dir;
    private Vector2 movement;
    private SpriteRenderer sb;

    public bool Flip { get; private set; }

    void Start()
    {
        sb = GetComponent<SpriteRenderer>();
        begin = transform.position.x;
        dir = 1;
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
        transform.localScale = new Vector2(0.7875f, 0.5375f);
        transform.localScale = new Vector2(-0.7875f, 0.5375f);


    }
}