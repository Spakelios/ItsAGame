using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyCollider : MonoBehaviour
{
    public GameObject gun;
    public bool enemySpotted;
    public GameObject angry;
    public HealthPack hpPack;
    public PlayerStats playerStats;
    

    private void Start()
    {
        gun.SetActive(false);
        enemySpotted = false;
        angry.SetActive(false);
    }
    

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            gun.SetActive(true);
            angry.SetActive(true);
            enemySpotted = true;
        }
        
        else if (other.gameObject.CompareTag("Player") && hpPack.packGot)
        {
            playerStats.hp += 1;
            hpPack.packGot = false;
            hpPack.healthPack.SetActive(false); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            gun.SetActive(false);
            angry.SetActive(false);
            enemySpotted = false;
        }
    }
}
