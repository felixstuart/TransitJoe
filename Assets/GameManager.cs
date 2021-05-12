using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{  
    [SerializeField]
    public int MaxTiles;
    [SerializeField]
    public List<GameObject> tiles;
    // Start is called before the first frame update
    void Start()
    {
        print(Screen.width);
        tiles.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
