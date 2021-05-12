using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Ludiq.FullSerializer;
using Random = UnityEngine.Random;


public class Data : MonoBehaviour
{
    public List<int> weighting;
    private float max;
    private float total;

    private void Start()
    {
        max =  100 / weighting.Count;
        foreach (var x in weighting)
        {
            total += x;
        }

        if (total != 100)
        {
            Debug.LogError("Your weighting is incorrect!");
        }
        print(max +" even weighting");
        print(Chance());
    }

    public int Chance()
    {
        int Event = 0;
        var r = Random.Range(0, 100);
        foreach (var x in Enumerable.Range(0,weighting.Count))
        {
            if (x == 0)
            {
                if (Enumerable.Range(0, weighting[x]).Contains(r))
                {
                    Event = 0;
                    print("setting 0");
                }
            }
            else
            {
                if (Enumerable.Range(weighting[x - 1], weighting[x]).Contains(r))
                {
                    Event = x;
                }
            }
        }
        
        return Event;
    }
    
}
