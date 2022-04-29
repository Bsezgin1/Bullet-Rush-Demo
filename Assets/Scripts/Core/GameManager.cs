using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] EnemyCounter enemyCounter;



    public Player player;
    [SerializeField] Transform playerSpawnPoint;



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
            player.gameObject.transform.position = playerSpawnPoint.position; 
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
        level = null;
    
    }

}


