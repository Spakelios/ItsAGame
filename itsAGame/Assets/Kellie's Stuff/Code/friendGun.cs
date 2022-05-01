using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class friendGun : MonoBehaviour
{
    public Transform enemy;
    public Transform launchOffset;

    public GameObject bullet;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            transform.LookAt(enemy);
            Instantiate(bullet, launchOffset.position, transform.rotation);
        }
    }

}
