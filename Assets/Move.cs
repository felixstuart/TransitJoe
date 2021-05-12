using System;
using System.Collections;
using System.Collections.Generic;
using Ludiq;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{

    public float x1;
    public float x2;
    public float acceleration;
    public float speed;

private void Update()
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

        speed += Time.realtimeSinceStartup * acceleration;
        MoveForward();
    }

    public void MoveLeft()
    {
        transform.position += new Vector3(-0.5f, 0.25f, 0);
    }
    public void MoveRight()
    {
        transform.position += new Vector3(0.5f, -0.25f, 0);
    }

    public void MoveForward()
    {
        transform.position +=
            new Vector3(2.5f*speed, 1.25f*speed, 0);
    }
}
