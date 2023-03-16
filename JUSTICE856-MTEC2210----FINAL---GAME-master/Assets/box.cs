using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class box : MonoBehaviour
{

    public int speed;
    public Rigidbody2D rb;

    // Use this for initialization
    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {

     ///   if (Input.GetKeyDown(KeyCode.DownArrow))
      ////  {
         ////   transform.Translate(Vector3.down* speed * Time.deltaTime * 3);
       ////     new Vector3(5f, 0f, 0f);
     ///   }

     ///   if (Input.GetKeyUp(KeyCode.UpArrow))
      ///  {
      ///      transform.Translate(Vector3.up * speed * Time.deltaTime  *3);

     ///   }
        

    }
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            rb.AddForce(Vector2.up * speed * Time.deltaTime);
            

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector2.down * speed * Time.deltaTime);

        }

    }

}