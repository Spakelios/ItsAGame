using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject aoe;
    public GameObject right;
    public GameObject arrow, arrowone, arrowtwo, text;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            aoe.SetActive(true);
            Destroy(arrow);
            Destroy(arrowone);
            Destroy(arrowtwo);
            Destroy(text);
            StartCoroutine(showtext());
        }
    }

    IEnumerator showtext()
    {
        right.SetActive(true);
        
        yield return new WaitForSeconds(1f);
        
        right.SetActive(false);
    }
}