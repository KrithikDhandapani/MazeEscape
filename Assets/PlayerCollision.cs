using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
   
    public void OnCollisionEnter(Collision collisionInfo)  
    {
        if(collisionInfo.collider.tag == "Restarter")
        {
            FindObjectOfType<gameManager>().EndGame();
        }
        if(collisionInfo.collider.tag == "End")
        {
            FindObjectOfType<gameManager>().ActualEnd();
        }
    }
}

