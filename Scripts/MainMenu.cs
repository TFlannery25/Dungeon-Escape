using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Transform player;
    public float speed;

    public void play ()
    {
        player.transform.Translate(200, 0, 0);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

   

    public void exit ()
    {
        player.transform.Translate(-200, 0, 0);
        Application.Quit();
    }
}
