using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FighterGiuseppe : MonoBehaviour
{
    public UnlevelledGiuseppe babyGiuseppe;
    public GameObject enemy;
    
    public GameObject angy;
    public GameObject concern;
    
    public GameObject enemyDetect;
    public ParticleSystem AOE;
    
    public NavMeshAgent giuseppe;
    public bool enemies;
    

    private void Start()
    {
        babyGiuseppe.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        enemy = GameObject.FindGameObjectWithTag("enemy");
        if (enemy)
        {
            angy.SetActive(true);
            concern.SetActive(false);

            transform.LookAt(enemy.transform);
            giuseppe.SetDestination(enemy.transform.position);
            
            StartCoroutine(Attack());
        }
        else
        {
            enemyDetect.SetActive(false);
        }
    }

    IEnumerator Attack()
    {
        enemyDetect.SetActive(true);
        AOE.Play();

        yield return new WaitForSeconds(1f);
        enemyDetect.SetActive(false);
    }
}
