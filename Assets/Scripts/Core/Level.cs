using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
 
    [SerializeField] public int levelId;
    GameManager gameManager;
    private void Start() 
    {
        gameManager = FindObjectOfType<GameManager>();
        gameManager.level = this;
        gameManager.lastLevel = levelId;
    }


}
