using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float life = 5f;
    private float lifeTimer =0;
    private float bulletDamage = 100;
   
    private void Update()
    {
        BulletLifeTimer();

    }

    private void BulletLifeTimer()
    {
        if (gameObject.activeInHierarchy)
        {
            lifeTimer += Time.deltaTime;
        }

        if (lifeTimer >= life)
        {
            gameObject.SetActive(false);
            lifeTimer = 0f;
        }
    }

    private void OnTriggerStay(Collider other) 
    {
       if(other.gameObject.CompareTag("Enemy"))
       {
            other.GetComponentInParent<Health>().TakeDamege(bulletDamage);
            gameObject.SetActive(false);
       }
       else 
       {
           return;
       }
        
    }
}
