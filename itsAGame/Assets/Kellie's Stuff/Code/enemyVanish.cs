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
    public HealthPack hpPack;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            enemypassed -= 1;
        }
        
        else if (other.CompareTag("Friend") && hpPack.packGot)
        {
            enemypassed += 1;
            hpPack.packGot = false;
            hpPack.healthPack.SetActive(false);
        }
    }

    public void Update()
    {
        fails.text = " " + enemypassed;

        if (enemypassed <= 0)
        {
            gameOver.SetActive(true);
        }
        else
        {
            gameOver.SetActive(false);
        }
    }
}
