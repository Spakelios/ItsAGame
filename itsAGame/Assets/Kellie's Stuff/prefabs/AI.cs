using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public Vector3 Exit;
    public NavMeshAgent Agent;
    
    void Start()
    {
        Agent.SetDestination(Exit);
    }

}