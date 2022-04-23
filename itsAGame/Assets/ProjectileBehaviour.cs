using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public float speed = 4;

    public void Update()
    {
        transform.position += transform.right * (Time.deltaTime * speed);
        StartCoroutine("vanish");
    }

    IEnumerator vanish()
    {
        yield return new WaitForSeconds(1f); 
        Destroy(prefab);
    }
}