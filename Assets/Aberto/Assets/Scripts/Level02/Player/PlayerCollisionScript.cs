using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    public GameManagerScript gameManager;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("GameOver!!!");
            FindObjectOfType<GameManagerScript>().GameOver();
        }
    }
}
