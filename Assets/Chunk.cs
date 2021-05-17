using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bolt;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Chunk : MonoBehaviour
{
    public TileBase tileA;
    public TileBase tileB;
    public BoundsInt area1;
    public BoundsInt area2;
    private int i;
    public List<int> length;
    void Start()
    {
        int RND = 0;//Random.Range(0, 2); //Get a random Number
        if (RND == 0)// If that number is zero...
        {
            print("Chunk 1"); //print the first chunk's name
            //Chunk02();//render second chunk
        }


    }

    void Generate()
    { 
        First(area1, i);
        i++;
        
    }

    public void Update()
    {
        Generate();
    }

    void First(BoundsInt area, int pos)
    {
        area.position = new Vector3Int((area.size.x) * pos, area.position.y, area.position.z);
        TileBase[] tileArray = new TileBase[area.size.x * (area.size.y+area.size.y+area.size.x) * area.size.z]; //get the fill size
        for (int index = 0; index < tileArray.Length; index++)
        {
            tileArray[index] = index % 2 == 0 ? tileA : tileB;
        }
        Tilemap tilemap = GetComponent<Tilemap>();
        tilemap.SetTilesBlock(area, tileArray);
    }
}