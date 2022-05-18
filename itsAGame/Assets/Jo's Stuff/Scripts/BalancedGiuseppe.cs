using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalancedGiuseppe : MonoBehaviour
{
    public UnlevelledGiuseppe babyGiuseppe;

    private void Start()
    {
        babyGiuseppe.enabled = false;
    }
}
