using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Animations;
using UnityEngine;

public class enemyVanish : MonoBehaviour
{
    public int enemypassed;
    public GameObject gameOver;
    public TextMeshProUGUI fails;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            enemypassed += 1;
            fails.text = " " + enemypassed;
        }
    }

    public void Update()
    {
        if (enemypassed >= 10)
        {
            gameOver.SetActive(true);
        }
        else
        {
            gameOver.SetActive(false);
        }
    }
}
