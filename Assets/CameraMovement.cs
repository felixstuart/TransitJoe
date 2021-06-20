using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 2;
    private void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Rigidbody.velocity = new Vector2(m_Thrust * 2, m_Thrust);
        
    }
}
