﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovementPlayer2 : MonoBehaviour
{
    public float racketMovementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float value = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, value) * racketMovementSpeed;
    }
}
