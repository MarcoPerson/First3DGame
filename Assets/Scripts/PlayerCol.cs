using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCol : MonoBehaviour
{
    public PlayerMov movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            // GetComponent<PlayerMov>().enabled = false;
            movement.enabled = false;
            FindObjectOfType<GameManagement>().GameOver();
        }
    }
}
