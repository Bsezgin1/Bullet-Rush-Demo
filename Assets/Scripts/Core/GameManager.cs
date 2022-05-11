using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] EnemyCounter enemyCounter;

    public Player player;
    [SerializeField] public Transform playerSpawnPoint;
    [SerializeField] public GameObject playerPrefab;


    public int lastLevel = 0;
    public Level level;

    public bool isWin;
    public bool isLose;
    public bool isGameStarted;
    

    void Update()
    {
       
        
        if(enemyCounter.IsEnemyFinished())
        {
            isWin = true;
           
        }

        

    }

    private void ClearTheScene()
    {
        player.transform.position = playerSpawnPoint.position;
        for (int i = 0; i < enemyCounter.enemies.Count; i++)
        {
            Destroy(enemyCounter.enemies[i]);
        }
       enemyCounter.enemies.Clear();
    }

    public void LoadNextLevel()
    {
        isLose=false;
        isWin=false;
        LevelManager.Instance.currentLevel++;
        LevelManager.Instance.GetLevel();
        ClearTheScene();
        EnemySpawner.Instance.SpawnEnemies(LevelManager.Instance.enemyAmount,LevelManager.Instance.bigEnemyAmount);
        
    }

    public void LoadSameLevel()
    {
        isLose=false;
        isWin=false;
        ClearTheScene();
        EnemySpawner.Instance.SpawnEnemies(LevelManager.Instance.enemyAmount,LevelManager.Instance.bigEnemyAmount);
       
        
    }

    public void StartGame()
    {
        isGameStarted = true;
        Instantiate(playerPrefab, playerSpawnPoint);
        EnemySpawner.Instance.SpawnEnemies(LevelManager.Instance.enemyAmount,LevelManager.Instance.bigEnemyAmount);
    }
}


