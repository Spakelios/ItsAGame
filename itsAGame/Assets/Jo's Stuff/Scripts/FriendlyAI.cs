using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FriendlyAI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent friend;
    public Transform healthPack;
    public PlayerStats playerStats;
    public HealthPack hpPack;
    public GameObject concern;
    public int hp;

    private void Start()
    {
        concern.SetActive(false);
    }

    private void Update()
    {
        hp = playerStats.hp;
        
        if (hp >= 3)
        {
            FollowPlayer();
        }

        else
        {
            HealPlayer();
        }

    }

    private void FollowPlayer()
    {
        transform.LookAt(player);
        friend.SetDestination(player.position);
        concern.SetActive(false);
    }

    private void HealPlayer()
    {
        concern.SetActive(true);

        if (hpPack.packGot != true)
        {
            transform.LookAt(healthPack);
            friend.SetDestination(healthPack.position);
        }

        else
        {
            transform.LookAt(player);
            friend.SetDestination(player.position);
        }
    }
}
