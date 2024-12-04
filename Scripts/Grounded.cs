using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = true;
        }
        if (collision.collider.tag == "Platform")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = true;
            Player.transform.parent = collision.gameObject.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = false;
        }
        if (collision.collider.tag == "Platform")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = false;
            Player.transform.parent = null;
        }
    }
   
    
        
}

