using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class BanditController : MonoBehaviour
{
    public bool active;

    public GameObject player;
    public Move ps;
    
    public int count;

    public int hearts = 1;
    // Update is called once per frame
    void Start()
    {
        //hearts++;
    }
    void Update()
    {
        if (hearts == 0 && active)
        {
            Destroy(gameObject);
        }
        if (active)
        {
            transform.position = new Vector3(player.transform.position.x - 0.5f, player.transform.position.y + 0.25f, player.transform.position.z);
        }
        
    }

    private void FixedUpdate()
    {
        count++;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            active = true;
        }
        if (other.gameObject.tag == "Hazard")
        {
            hearts = hearts - 1;
        }

    }
}
