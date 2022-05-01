using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class atmousepoint : MonoBehaviour
{
    public RawImage image;
    public Transform playerPos;
    void Start()
    {
        image.transform.position = transform.position;
    }

    private void Update()
    {
        image.transform.position = transform.position;
    }
}
