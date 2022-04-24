using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

public class Aimer : MonoBehaviour
{
    private Vector3 mousePos;
    public int minX, maxX, minY, maxY;

    void Update()
    {
        mousePos = Input.mousePosition;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            this.transform.LookAt(hit.point);
            this.GetComponent<Rigidbody>().velocity = this.transform.forward * 10;
        }

        mousePos.x = Mathf.Clamp(mousePos.x, minX, maxX); 
        mousePos.y = Mathf.Clamp(mousePos.y, minY, maxY);
    } 
}