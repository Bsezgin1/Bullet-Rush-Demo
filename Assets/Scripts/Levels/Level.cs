using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="New Level")]
public class Level : ScriptableObject
{
 
    public int levelId;
    public int enemyAmount;
    public int bigEnemyAmount;


    private void Start() 
    {
        
        //GameManager.Instance.level = this;
        //GameManager.Instance.lastLevel = levelId;
    }


}
