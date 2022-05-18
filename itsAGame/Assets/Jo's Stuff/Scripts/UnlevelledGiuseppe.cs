using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.AI;

public class UnlevelledGiuseppe : MonoBehaviour
{
    public Transform player;
    public GameObject enemy;
    public GameObject healthPack;
    public HealthPack hpPack;
    private GameObject[] enemies; //gonna change the enemy gameobject to an array but later
    public NavMeshAgent giuseppe;
    public int numberKills;
    public int numberHeals;
    
    //this is me just testing to see if the fixedUpdate stuff works; get rid of later
    public bool killerGiuseppe;
    public bool healerGiuseppe;
    public bool balancedGiuseppe;
    
    public GameObject angy;
    public GameObject concern;
    
    public bool healerMode;

    private void Start()
    {
        angy.SetActive(false);
        concern.SetActive(false);
        Idle();
    }

    
    private void Update()
    {
        enemy = GameObject.FindGameObjectWithTag("enemy");
    }
    

    private void FixedUpdate()
    {
        if (numberKills + numberHeals == 6)
        {
            if (numberKills > numberHeals)
            {
                killerGiuseppe = true;
            }
            
            else if (numberKills < numberHeals)
            {
                healerGiuseppe = true;
            }
            
            else if (numberKills == numberHeals)
            {
                balancedGiuseppe = true;
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

        if (concern.activeInHierarchy)
        {
            concern.SetActive(false);
        }
        
        transform.LookAt(enemy.transform);
        giuseppe.SetDestination(enemy.transform.position);
    }

    public void Heal()
    {
        healerMode = true;
        concern.SetActive(true);

        if (angy.activeInHierarchy)
        {
            angy.SetActive(false);
        }

        if (hpPack.packGot)
        {
            transform.LookAt(player);
            giuseppe.SetDestination(player.position);
        }

        else
        {
            transform.LookAt(healthPack.transform);
            giuseppe.SetDestination(healthPack.transform.position);
        }
    }

}

