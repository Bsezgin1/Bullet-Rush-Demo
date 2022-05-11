using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoSingleton<LevelManager>
{
    public Level[] levels;
    public Level level;
    public int currentLevel=0;
    public int enemyAmount;
    public int bigEnemyAmount;

    private void Awake() 
    {
        GetLevel();
    }

    public void GetLevel()
    {
        level = levels[currentLevel];
        enemyAmount = level.enemyAmount;
        bigEnemyAmount = level.bigEnemyAmount;
    }
}
