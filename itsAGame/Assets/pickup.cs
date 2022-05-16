using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject aoe;
    public GameObject right;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            aoe.SetActive(true);
            StartCoroutine(showtext());
        }
    }

    IEnumerator showtext()
    {
        right.SetActive(true);
        yield return new WaitForSeconds(3f);
        right.SetActive(false);
    }
}