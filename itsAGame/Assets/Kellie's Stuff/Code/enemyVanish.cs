using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.Animations; //was giving an error so
using UnityEngine;

public class enemyVanish : MonoBehaviour
{
    public int enemypassed;
    public GameObject gameOver;
    public TextMeshProUGUI fails;
    public HealthPack hpPack1;
    public HealthPack hpPack2;
    public HealthPack hpPack3;
    public PlayerStats playerStats;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            enemypassed -= 1;
        }
        
        else if (other.CompareTag("Friend"))
        {
            if (hpPack1.packGot)
            {
                enemypassed += 1;
                hpPack1.packGot = false;
                hpPack1.healthPack.SetActive(false);
            }
            
            else if (hpPack2.packGot)
            {
                enemypassed += 1;
                hpPack2.packGot = false;
                hpPack2.healthPack.SetActive(false);
            }
            
            else if (hpPack3.packGot)
            {
                enemypassed += 1;
                hpPack3.packGot = false;
                hpPack3.healthPack.SetActive(false);
            }
        }
        
        else if (other.CompareTag("HealerFriend"))
        {
            if (hpPack1.packGot)
            {
                enemypassed += 2;
                hpPack1.packGot = false;
                hpPack1.healthPack.SetActive(false);
            }
            
            else if (hpPack2.packGot)
            {
                enemypassed += 2;
                hpPack2.packGot = false;
                hpPack2.healthPack.SetActive(false);
            }
            
            else if (hpPack3.packGot)
            {
                enemypassed += 2;
                hpPack3.packGot = false;
                hpPack3.healthPack.SetActive(false);
            }
        }
    }

    public void Update()
    {
        fails.text = " " + enemypassed;

        if (enemypassed <= 0 || playerStats.hp <= 0)
        {
            gameOver.SetActive(true);
        }
        else
        {
            gameOver.SetActive(false);
        }
    }
}
