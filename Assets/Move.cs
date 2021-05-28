using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 20f;
    public float x1;
    public float x2;
    public List<Image> hearts;
    public Scene GameOver;

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

        if (hearts.Count == 0)
        {
            print("Game Over!");
            SceneManager.LoadScene("Game Over");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (hearts.Count > 0)
        {
            Destroy(hearts[0]);
            hearts.RemoveAt(0);
        }
        if (hearts.Count == 0)
        {
            print("Game Over");
        }

    }
}