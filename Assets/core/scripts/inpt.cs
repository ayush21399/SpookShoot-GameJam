﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inpt : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 InputVector { get; private set; }
    public Vector3 MousePos { get; private set; }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        InputVector = new Vector2(h, v);

        MousePos = Input.mousePosition;
    }
}
