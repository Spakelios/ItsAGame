using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public ProjectileBehaviour ProjectilePrefab;
    public Transform launchOffset;

    public float speed;
    public Vector3 targetPosition;
    private void OnMouseDown()
    {
        Instantiate(bullet);
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet);
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }

        // this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ProjectilePrefab, launchOffset.position, transform.rotation);
        }

    }
}
