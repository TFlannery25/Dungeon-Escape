using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpinTrapCW : MonoBehaviour
{
    public Transform spinTrap;
    public float speed;
  

    // Update is called once per frame
    void Update()
    {
        spinTrap.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
