using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    public GameObject gun;
    public bool enemySpotted;
    public GameObject angry;

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
