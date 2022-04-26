using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FriendlyAI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent friend;

    private void Update()
    {
        transform.LookAt(player);
        friend.SetDestination(player.position);
    }
}
