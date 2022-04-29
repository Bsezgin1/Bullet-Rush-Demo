using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float life = 5f;
    private float bulletDamage = 100;
    private void Awake() 
    {
        Destroy(gameObject, life);
    }
    
    private void OnTriggerStay(Collider other) 
    {
       if(other.gameObject.CompareTag("Enemy"))
       {
            other.GetComponentInParent<Health>().TakeDamege(bulletDamage);
            Destroy(gameObject);
       }
       else 
       {
           return;
       }
        
    }
}
