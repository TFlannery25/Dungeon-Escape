using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float rotation;
    public bool isGrounded = false;
    public Rigidbody2D rb;
    public float speed;
    public float jumpHeight;


   



    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(x, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true) 
        {
            rb.velocity = Vector2.up * jumpHeight;
            
        }
        transform.rotation = Quaternion.Euler(0, 0, 0);



        


    }
    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "LevelComplete")
        {
            FindObjectOfType<GameManager>().levelComplete();
        }
        if (collisionInfo.collider.tag == "Trap")
        {
            FindObjectOfType<GameManager>().restart();
        }
        

        

    }
    



}
