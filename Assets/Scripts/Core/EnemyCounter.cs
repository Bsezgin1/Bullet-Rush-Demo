using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] public Text enemyRemainingText;
    public List<GameObject> enemies;
    bool isFinished;

    
    void Update()
    {   
        if(!GameManager.Instance.isGameStarted) return;
        enemyRemainingText.text = enemies.Count.ToString();
        
        CheckEnemies();
    }

    private void CheckEnemies()
    {
        if (enemies.Count == 0)
        {
            isFinished = true;
        }
        else
        {
            isFinished = false;
        }
    }

    public bool IsEnemyFinished()
    {
        return isFinished;
    }
}
