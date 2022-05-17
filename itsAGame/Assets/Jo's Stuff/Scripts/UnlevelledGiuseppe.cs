using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.AI;

public class UnlevelledGiuseppe : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent giuseppe;
    public int numberKills;
    public int numberHeals;
    public bool killerGiuseppe;
    public bool healerGiuseppe;
    public bool balancedGiuseppe;
    private bool fighting;
    private bool healing;
    public GameObject angy;
    public GameObject concern;

    private void Start()
    {
        angy.SetActive(false);
        concern.SetActive(false);
    }

    private void Update()
    {
        if (!fighting || !healing)
        {
            Idle();
        }
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
        fighting = true;
        angy.SetActive(true);

        if (concern.activeInHierarchy)
        {
            concern.SetActive(false);
        }
    }

    public void Heal()
    {
        healing = true;
        concern.SetActive(true);

        if (angy.activeInHierarchy)
        {
            angy.SetActive(false);
        }
    }

}

