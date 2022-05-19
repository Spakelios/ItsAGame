using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public TextMeshProUGUI hpCount;
    public int hp;
    public int hpCap;
    public HealthPack hpPack1;
    public HealthPack hpPack2;
    public HealthPack hpPack3;

    private void Update()
    {
        hpCount.text = "HP: " + hp;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            hp-= 1;
            Destroy(other.gameObject);
        }
        
        else if (other.tag == "Friend")
        {
            if (hpPack1.packGot && hp < hpCap)
            {
                hp += 1;
                hpPack1.packGot = false;
                hpPack1.healthPack.SetActive(false);
            }
            
            else if (hpPack2.packGot && hp < hpCap)
            {
                hp += 1;
                hpPack2.packGot = false;
                hpPack2.healthPack.SetActive(false);
            }
            
            else if (hpPack3.packGot && hp < hpCap)
            {
                hp += 1;
                hpPack3.packGot = false;
                hpPack3.healthPack.SetActive(false);
            }
            
            
        }
        
        else if (other.tag == "HealerFriend")
        {
            if (hpPack1.packGot && hp < hpCap)
            {
                hp += 2;
                hpPack1.packGot = false;
                hpPack1.healthPack.SetActive(false);
            }
            
            else if (hpPack2.packGot && hp < hpCap)
            {
                hp += 2;
                hpPack2.packGot = false;
                hpPack2.healthPack.SetActive(false);
            }
            
            else if (hpPack3.packGot && hp < hpCap)
            {
                hp += 2;
                hpPack3.packGot = false;
                hpPack3.healthPack.SetActive(false);
            }
        }
    }
}
