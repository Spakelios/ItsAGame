using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

public class Aimer : MonoBehaviour
{
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
 
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            this.transform.LookAt(hit.point);
            this.GetComponent<Rigidbody>().velocity = this.transform.forward * 10;
        }
    } 
}