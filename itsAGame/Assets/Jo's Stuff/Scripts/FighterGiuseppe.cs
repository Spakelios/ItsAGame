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
    public GameObject stateButtons;
    public GameObject fighterText;
    

    private void Start()
    {
        stateButtons.SetActive(false);
        fighterText.SetActive(true);
        babyGiuseppe.enabled = false;
        angy.SetActive(true);
        concern.SetActive(false);
        gameObject.tag = "FighterFriend";
        giuseppe.speed = 20;
    }

    private void OnTriggerEnter(Collider other)
    {
        enemy = GameObject.FindGameObjectWithTag("enemy");
        if (enemy)
        {
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
