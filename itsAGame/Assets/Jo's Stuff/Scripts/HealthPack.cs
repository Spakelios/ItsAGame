using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public GameObject healthPack;
    public UnlevelledGiuseppe giuseppe;
    public bool packGot;

    private void Start()
    {
        packGot = false;
        healthPack.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Friend") && giuseppe.healerMode)
        {
            packGot = true;
            healthPack.SetActive(true);
        }
    }
}
