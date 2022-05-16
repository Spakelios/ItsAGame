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

        StartCoroutine(Delay());
    }
    
    IEnumerator Delay()
    {
      
    if (Input.GetMouseButton(1))
        {
            yield return new WaitForSeconds(0.5f);
            aoe.SetActive(true);
            particleSystem.Play();
        }
        else
        {
            aoe.SetActive(false);
        }
    }
}

