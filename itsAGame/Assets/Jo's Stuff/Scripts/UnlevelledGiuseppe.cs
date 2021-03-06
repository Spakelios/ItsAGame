using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Timeline;

public class UnlevelledGiuseppe : MonoBehaviour
{
    public Transform player;
    public GameObject enemy;
    public GameObject healthPack;
    public HealthPack hpPack;
    public NavMeshAgent giuseppe;
    public int numberKills;
    public int numberHeals;

    public GameObject angy;
    public GameObject concern;

    public FighterGiuseppe fighterLevel;
    public HealerGiuseppe healerLevel;

    public PlayerStats playerStats;
    public enemyVanish baseHP;
    public Transform theBase;

    public bool fighterMode;
    public bool healerMode;

    public GameObject enemyDetect;
    public ParticleSystem AOE;

    public GameObject stateButtons;

    private void Start()
    {
        angy.SetActive(false);
        concern.SetActive(false);
        fighterLevel.enabled = false;
        healerLevel.enabled = false;
        //playerStats = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
        //baseHP = GameObject.FindWithTag("Based").GetComponent<enemyVanish>();
        stateButtons.SetActive(true);
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

        if (numberKills + numberHeals >= 5)
        {
            if (numberKills > numberHeals)
            {
                fighterLevel.enabled = true;
            }

            else if (numberKills < numberHeals)
            {
                Destroy(enemyDetect);
                healerLevel.enabled = true;
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
        healerMode = false;
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
        fighterMode = false;
        fightCheck = false;
        enemyDetect.SetActive(false);
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
            numberHeals ++;
        }

        if (enemy && fightCheck)
        { 
            enemyDetect.SetActive(true);
            AOE.Play();
        }
    }
    
    

}

