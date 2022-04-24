using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent Agent;
    
    void Start()
    {
        Agent.SetDestination(player.position);
    }

}