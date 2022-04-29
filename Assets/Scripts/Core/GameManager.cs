using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] EnemyCounter enemyCounter;



    public Player player;
    [SerializeField] public Transform playerSpawnPoint;
    [SerializeField] public GameObject playerPrefab;


    public int lastLevel = 0;
    public Level level;
    [SerializeField] public Level[] allLevels;


    public bool isWin;
    public bool isLose;
    public bool isGameStarted;
    

    void Update()
    {
        
        if(!level) return;
        if(enemyCounter.IsEnemyFinished())
        {
            isWin = true;
            ClearTheScene();
        }

        if(player.isDead)
        {
            isLose = true;     
            ClearTheScene();
        }

    }

    private void ClearTheScene()
    {
        Destroy(level.gameObject);
        enemyCounter.enemies.Clear();
        Destroy(player.gameObject);
        level = null;
    
    }

    public void LoadNextLevel()
    {
        isLose=false;
        isWin=false;
        Instantiate(playerPrefab, playerSpawnPoint);
        Instantiate(allLevels[lastLevel+1]);
    }

    public void LoadSameLevel()
    {
        isGameStarted = true;
        isLose=false;
        isWin=false;
        Instantiate(playerPrefab, playerSpawnPoint);
        Instantiate(allLevels[lastLevel]);
    }

}


