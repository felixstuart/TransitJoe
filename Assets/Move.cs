using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 20f;
    public float x1;
    public float x2;
    public float acceleration;
    public float speed;
    public List<Image> hearts;

    private void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Rigidbody.velocity = new Vector2(m_Thrust * 2, m_Thrust);
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            x1 = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
        {
            x2 = Input.mousePosition.x;
            if (x1 > x2)
            {
                print("Move Left");
                MoveLeft();
            }

            if (x1 < x2)
            {
                print("Move Right");
                MoveRight();
            }
        }

    }

    public void MoveLeft()
    {
        transform.position += new Vector3(-0.5f, 0.25f, 0);
    }

    public void MoveRight()
    {
        transform.position += new Vector3(0.5f, -0.25f, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}