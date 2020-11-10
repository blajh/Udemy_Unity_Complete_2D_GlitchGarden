﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
	[Range (0f, 5f)]
	[SerializeField] private float _walkSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _walkSpeed);
    }
}