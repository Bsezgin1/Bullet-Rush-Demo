using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField]public GameManager gameManager;
    public void NextLevel()
    {
        gameManager.isLose = false;
        gameManager.isWin = false;
        Instantiate(gameManager.allLevels[gameManager.lastLevel+1]);
    }

    public void Restart()
    {
        gameManager.isGameStarted = true;
        gameManager.isLose = false;
        gameManager.isWin = false;
        Instantiate(gameManager.allLevels[gameManager.lastLevel]);
    }
}
