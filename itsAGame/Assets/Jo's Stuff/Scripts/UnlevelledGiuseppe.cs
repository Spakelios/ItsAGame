using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Timeline;

public class UnlevelledGiuseppe : MonoBehaviour
{
    public Transform player;
    public GameObject enemy;
    public GameObject healthPack;
    public HealthPack hpPack;
    private GameObject[] enemies; //gonna change the enemy gameobject to an array but later
    public NavMeshAgent giuseppe;
    public static int numberKills;
    public int numberHeals;

    public GameObject angy;
    public GameObject concern;

    public FighterGiuseppe fighterLevel;
    public HealerGiuseppe healerLevel;
    public BalancedGiuseppe balancedLevel;

    private PlayerStats playerStats;
    private enemyVanish baseHP;
    public Transform theBase;

    public bool fighterMode;
    public bool healerMode;

    public GameObject enemyDetect;
    public ParticleSystem AOE;

    private void Start()
    {
        angy.SetActive(false);
        concern.SetActive(false);
        fighterLevel.enabled = false;
        healerLevel.enabled = false;
        balancedLevel.enabled = false;
        playerStats = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
        baseHP = GameObject.FindWithTag("Based").GetComponent<enemyVanish>();
    }

    private void FixedUpdate()
    {
        if (fighterMode)
        {
            Fight();
        }

        else if (healerMode)
        {
            Heal();
        }

        else
        {
            Idle();
        }

        if (numberKills + numberHeals == 6)
        {
            if (numberKills > numberHeals)
            {
                fighterLevel.enabled = true;
            }

            else if (numberKills < numberHeals)
            {
                healerLevel.enabled = true;
            }

            else if (numberKills == numberHeals)
            {
                balancedLevel.enabled = true;
            }
        }
    }

    private void Idle()
    {
        transform.LookAt(player);
        giuseppe.SetDestination(player.position);
    }

    public void Fight()
    {
        angy.SetActive(true);
        enemy = GameObject.FindGameObjectWithTag("enemy");
        
        concern.SetActive(false);
        transform.LookAt(enemy.transform);
        giuseppe.SetDestination(enemy.transform.position);

        fightCheck = true;
    }

    public bool fightCheck;
    public void Heal()
    {
        concern.SetActive(true);
        angy.SetActive(false);

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Based") && hpPack.packGot || other.CompareTag("Player") && hpPack.packGot)
        {
            numberHeals += 1;
        }

        if (enemy && fightCheck)
        {
            enemyDetect.SetActive(true);
            AOE.Play();
        }
    }
    
    

}

