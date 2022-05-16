using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AOE : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public GameObject aoe;
    public void Update()
    {
        if (Input.GetMouseButton(1))
        {
            aoe.SetActive(true);
            particleSystem.Play();
        }
        else
        {
            aoe.SetActive(false);
        }
    }
}

