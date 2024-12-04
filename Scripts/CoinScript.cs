    using System.Collections;
using System.Collections.Generic;
//using System.Security.Policy;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public GameObject coin;
    
        void OnCollisionEnter2D(Collision2D collisionInfo)
        {
            if (collisionInfo.collider.tag == "Player")
            {
                Destroy(coin);
            }
        }
    

}