using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class atmousepoint : MonoBehaviour
{
    public RawImage image;
    void Start()
    {
        image.transform.position = Input.mousePosition;
    }

    private void Update()
    {
        image.transform.position = Input.mousePosition;
    }
}
