﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * _speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}