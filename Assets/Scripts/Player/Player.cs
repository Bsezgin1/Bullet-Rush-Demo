using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isDead;
    FollowCamera followCamera;
    GameManager gameManager;

    private void Start() 
    {
        followCamera = FindObjectOfType<FollowCamera>();
        followCamera.target = gameObject.transform;

        gameManager = FindObjectOfType<GameManager>();
        gameManager.player = this;
    }


    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
    
    
    private void Die()
    {
        isDead = true;
       //Destroy(gameObject);
    }

    
}
