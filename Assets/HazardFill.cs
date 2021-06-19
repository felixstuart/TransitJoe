using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class HazardFill : MonoBehaviour
{
    public int Position;

    public GameObject hazard;

    [FormerlySerializedAs("children")] public List<Vector2> positions;
    // This function is called when the object comes invisible
    void OnBecameInvisible()
    {
        print(gameObject.name+" is invisible.");
        int child1 = Random.Range(0, positions.Count);
        int child2 = Random.Range(0, positions.Count);
                int child3 = Random.Range(0, positions.Count);
                int child4 = Random.Range(0, positions.Count);
                int child5 = Random.Range(0, positions.Count);
                Instantiate(hazard, positions[0], Quaternion.identity, null);
        Instantiate(hazard, positions[1], Quaternion.identity, null);
        Instantiate(hazard, positions[2], Quaternion.identity, null);
        Instantiate(hazard, positions[3], Quaternion.identity, null);
        Instantiate(hazard, positions[4], Quaternion.identity, null);
    }

}
