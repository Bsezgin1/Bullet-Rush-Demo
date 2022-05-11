using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoSingleton<EnemySpawner>
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject bigEnemyPrefab;
    public int enemyAmount;
    public int bigEnemyAmount;

    public int xPos;
    public int zPos;
    private void Start() 
    {
        enemyAmount = LevelManager.Instance.enemyAmount;
        bigEnemyAmount = LevelManager.Instance.bigEnemyAmount;
        
    }

    public void SpawnEnemies(int enemyAmount, int bigEnemyAmount)
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            
          xPos = Random.Range(-25,25);
          zPos = Random.Range(12,28);
          Instantiate(enemyPrefab,new Vector3(xPos,0,zPos),Quaternion.identity);
        }

        for (int i = 0; i < bigEnemyAmount; i++)
        {
            xPos = Random.Range(-8,8);
            zPos = Random.Range(30,38);
            Instantiate(bigEnemyPrefab,new Vector3(xPos,0,zPos),Quaternion.identity);
        }
    }

}
