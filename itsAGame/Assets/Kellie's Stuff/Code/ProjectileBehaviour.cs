using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;

public class ProjectileBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public float speed = 4;

    public void Update()
    {
        transform.position += transform.right * (Time.deltaTime * speed);
        FindClosestEnemy();
        StartCoroutine("vanish");
    }

    IEnumerator vanish()
    {
        yield return new WaitForSeconds(5f); 
        Destroy(prefab);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
    }
    
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}

