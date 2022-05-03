using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{

    public LayerMask whatIsPlayer;
    public Transform launchOffset;
    public float attackRange;
    public bool playerInSightRange, playerInAttackRange;

    public Vector3 Exit;
    public NavMeshAgent Agent;
    
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;

    private Transform player;
    
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        Agent.SetDestination(Exit);
    }
    
    private void Update()
    {
        //Check for sight and attack range
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        
        if (playerInAttackRange && playerInSightRange) AttackPlayer();
    }
    
    private void AttackPlayer()
    {
        //Make sure enemy doesn't move
        Agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            Instantiate(projectile, launchOffset.position, transform.rotation);

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }

}