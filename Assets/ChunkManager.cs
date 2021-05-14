using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    public List<GameObject> chunks;
    public GameObject toSpawn;
    private int last;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        last = chunks.Count - 1;
        if (chunks[last].activeSelf)
        {
            //chunks[last].transform.pos
            GameObject go = Instantiate(toSpawn, chunks[last].transform);
            go.SetActive(true);
        }
    }
}
