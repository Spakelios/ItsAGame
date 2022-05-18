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
    public HealthPack hpPack;

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
            if (hpPack.packGot && hp < hpCap)
            {
                hp += 1;
                hpPack.packGot = false;
                hpPack.healthPack.SetActive(false);

            }
        }
        
        else if (other.tag == "HealerFriend")
        {
            if (hpPack.packGot && hp < hpCap)
            {
                hp+= 2;
                hpPack.packGot = false;
                hpPack.healthPack.SetActive(false);

            }
        }
    }
}
