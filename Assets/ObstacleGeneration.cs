using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ObstacleGeneration : MonoBehaviour
{
    public int row;
    public int column;
    public Tilemap tilemap;
    public TileBase hazard;
    public BoundsInt area;
    private Vector3Int Position = new Vector3Int();

    void Start()
    {
        TileBase[] tileArray = new TileBase[area.size.x * area.size.y * area.size.z];
        tileArray[column] = hazard;
        tilemap.SetTilesBlock(area, tileArray);

    }
}
