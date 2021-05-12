using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.Tilemaps;

public class TestingScripts : MonoBehaviour
{
    public float speed;
    public Tile square;

    public List<Tile> squares;

    public Tilemap squaremap;

    public Tile tile;
    public List<int> sizeX;
    public List<int> sizey;
    
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Effect", 2.0f, speed);
        //Effect();
        Populate();
        //IsometricPopulate();
        print("This is for alignment of the grid to the world point. It is recommended that you put the generated square in the cornder");
    }

    // Update is called once per frame
    void Update()
    {
        //Effect();
    }

    void Populate()
    {
        foreach (var x in Enumerable.Range(0, sizeX.Count))
        {
            int RND = Random.Range(0, squares.Capacity);
            print(RND);
            squaremap.SetTile(new Vector3Int(x,0,0), squares[RND]);
            foreach (var y in Enumerable.Range(0, sizey.Count/2))
            {
                int RNDsecond = Random.Range(0, squares.Capacity);
                print(RNDsecond);
                squaremap.SetTile(new Vector3Int(x,y,0), squares[RNDsecond]);
            }
        }
    }

    void SetUp(Tile tile)
    {
        squaremap.SetTile(new Vector3Int(0,0,0), tile);
    }

    void Effect()
    {
        foreach (var x in Enumerable.Range(0, sizeX.Count))
        {
            foreach (var y in Enumerable.Range(0, sizey.Count))
            {
                int RNDsecond = Random.Range(0, squares.Capacity);
                squaremap.SetTile(new Vector3Int(x,y,0), squares[RNDsecond]);
            }
        }
    }
}
