﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHACK : MonoBehaviour
{
    public float speed = 10.0f;

    // Use this for initialization
    void Start ()
    {
        
    }
	
    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
