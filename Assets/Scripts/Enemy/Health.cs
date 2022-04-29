using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   
    [SerializeField] private float healthPoints;
    Enemy enemy;
    private void Awake() {
        enemy = GetComponent<Enemy>();
    }
   public void TakeDamege(float damage)
   {
       healthPoints = Mathf.Max(healthPoints - damage, 0);

        if(healthPoints == 0)
        {
            Die();
        }
   }
    
    private void Die()
    {
        enemy.enemyCounter.enemies.Remove(gameObject);
        Destroy(gameObject);
    }

    public float GetHealth()
    {
        return healthPoints;
    }
}
