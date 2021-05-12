using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.Tilemaps;

public class GenMap : MonoBehaviour
{
    public List<int> sizeX;

    public List<int> sizeY;

    public List<Tile> GroundTiles;

    public Tilemap GroundMap;

    // Start is called before the first frame update
    void Start()
    {
        Populate();
    }

    // Update is called once per frame

    void Populate()
    {
        foreach (var x in Enumerable.Range(0, sizeX.Count))
        {
            int RND = Random.Range(0, GroundTiles.Capacity);
            print(RND);
            GroundMap.SetTile(new Vector3Int(x, 0, 0), GroundTiles[RND]);
            foreach (var y in Enumerable.Range(0, sizeY.Count / 2))
            {
                int RNDsecond = Random.Range(0, GroundTiles.Capacity);
                print(RNDsecond);
                GroundMap.SetTile(new Vector3Int(x, y, 0), GroundTiles[RNDsecond]);
            }
        }
    }
}
