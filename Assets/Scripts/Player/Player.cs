using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoSingleton<Player>
{
    public bool isDead;
    FollowCamera followCamera;

    private void Start() 
    {
        followCamera = FindObjectOfType<FollowCamera>();
        followCamera.target = gameObject.transform;

        
        GameManager.Instance.player = this;
        
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
        GameManager.Instance.isLose = true;
    }

    
}
