using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMover : MonoBehaviour
{
    private GameObject player;
    private float range = 15f;
    [SerializeField] private NavMeshAgent navMeshAgent;

    private 
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        if(!player) return;
        float distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);
        if(distanceToPlayer < range)
        {
            navMeshAgent.destination = player.transform.position;
        }
    }
}
