using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AOE : MonoBehaviour
{
    public ParticleSystem particleSystem;
    
    public void Update()
    {
        if (Input.GetMouseButton(1))
        {
            particleSystem.Play();
            CheckForDestruction();
        }
    }

    public void CheckForDestruction()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 4f);
        foreach (Collider c in colliders)
        {
            if (c.CompareTag("enemy"))
            {
                Destroy(c.gameObject);
            }
        }
    }
}

