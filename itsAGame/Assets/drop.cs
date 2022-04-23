using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class drop : MonoBehaviour
{
    public static int dropValue = 1;
    
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(dropValue);
        }
    }
}