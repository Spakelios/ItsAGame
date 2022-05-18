using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            UnlevelledGiuseppe.numberKills++;
        }
}
}
