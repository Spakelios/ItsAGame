using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public UnlevelledGiuseppe unlevelledGiuseppe;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            unlevelledGiuseppe.numberKills += 1;
        }
}
}
