using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float thrust;
    private void Start()
    {
        rb.velocity = new Vector2((speed * 2) * thrust, speed * thrust);
    }
}
