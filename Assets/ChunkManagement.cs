using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Build.Content;
using UnityEngine;

public class ChunkManagement : MonoBehaviour
{
    private bool isInvisible;
    // Start is called before the first frame update
    void Start()
    {
        GameObject o;
        (o = gameObject).name = transform.position.ToString();
    }
    
    private void OnBecameInvisible()
    {
        isInvisible = true;
        print(gameObject.name + " Is Invisible");
    }

    private void OnBecameVisible()
    {
        isInvisible = false;
        print(gameObject.name + " Is Visible");
    }

    private void FixedUpdate()
    {
        if (isInvisible)
        {
            transform.position =
                new Vector3(transform.position.x + 2.5f, transform.position.y + 1.25f, transform.position.z);
        }
    }
}
