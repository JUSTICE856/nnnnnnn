using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private SpriteRenderer Player;
    private Color col;
    private float activationTime;
    private bool invisible;

    void Start()
    {
        Player = GetComponent<SpriteRenderer>();
        activationTime = 0;
        invisible = false;
        col = Player.color;
    }

    // Update is called once per frame
    void Update()
    {
        activationTime += Time.deltaTime;
        if(invisible && activationTime > 20)
        {
            invisible = false;
            col.a = 1;
            Player.color = col;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Invisible")
        {
            invisible = true;
            activationTime = 0;
            col.a = .2f;
            Player.color = col; 
            other.gameObject.SetActive(false);
        }
        
    }
}
