using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealerGiuseppe : MonoBehaviour
{
    public UnlevelledGiuseppe babyGiuseppe;
    
    public Transform player;
    public GameObject healthPack;
    public HealthPack hpPack;
    public NavMeshAgent giuseppe;
    public GameObject concern;
    public bool healerMode;

    private void Start()
    {
        babyGiuseppe.enabled = false;
        healerMode = true;
    }
}
