using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField]public GameManager gameManager;
    public void NextLevel()
    {
        gameManager.LoadNextLevel();
    }

    public void Restart()
    {
        gameManager.LoadSameLevel();
    }

    public void StartGame()
    {
        gameManager.StartGame();
    }
}
