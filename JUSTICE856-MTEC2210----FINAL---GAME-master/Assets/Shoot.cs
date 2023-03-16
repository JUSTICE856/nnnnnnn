using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;
public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletprefab;
    void Start()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletprefab, shootingPoint.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
