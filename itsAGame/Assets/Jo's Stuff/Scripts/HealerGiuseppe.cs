using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealerGiuseppe : MonoBehaviour
{
    public UnlevelledGiuseppe babyGiuseppe;
    
    public Transform player;
    public GameObject healthPack;
    public HealthPack hpPack;
    public NavMeshAgent giuseppe;
    
    public GameObject concern;

    private PlayerStats playerStats;
    private enemyVanish baseHP;
    public Transform theBase;
    

    private void Start()
    {
        babyGiuseppe.enabled = false;
        concern.SetActive(true);
        gameObject.tag = "HealerFriend";
        giuseppe.speed = 20;
        playerStats = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
        baseHP = GameObject.FindWithTag("Based").GetComponent<enemyVanish>();
    }

    private void FixedUpdate()
    {
        Heal();
    }

    private void Heal()
    {
        if (hpPack.packGot)
        {
            if (baseHP.enemypassed > playerStats.hp)
            {
                transform.LookAt(player);
                giuseppe.SetDestination(player.position);
            }
            
            else if (baseHP.enemypassed <= playerStats.hp)
            {
                transform.LookAt(theBase);
                giuseppe.SetDestination(theBase.position);
            }
        }

        else
        {
            transform.LookAt(healthPack.transform);
            giuseppe.SetDestination(healthPack.transform.position);
        }
    }
}
