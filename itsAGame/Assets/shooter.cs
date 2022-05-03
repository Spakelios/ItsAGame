using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    public ProjectileBehaviour ProjectilePrefab;
    public Transform launchOffset;
    private Transform balls;
    public float speed;
    public Vector3 targetPosition;
    private void OnMouseDown()
    {
        Instantiate(bullet);
    }

    private void Awake()
    {
        balls = GameObject.Find("Evil Balls__(").transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet);
            targetPosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ProjectilePrefab, launchOffset.position, transform.rotation);
        }

    }
}