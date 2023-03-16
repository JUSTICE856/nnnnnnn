using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enee : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 3f;
    private float damageAmount;
    public Animator animComponent;

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health -= damageAmount;

        if(health <= 0)
        {
             Destroy(gameObject);
            
        }
    }
}
