using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class HomingScript : MonoBehaviour
{

    public Transform player;
    public float speed;
    Vector3 Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = player.position;
        transform.position = Vector3.MoveTowards(transform.position, Player, speed * Time.deltaTime);
    }
}
