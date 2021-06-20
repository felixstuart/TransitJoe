using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Serialization;

public class IsometricGen : MonoBehaviour
{
    public GameObject twin;
    private readonly Vector3 _change = new Vector3(2.5f, 1.25f, 0.0f);
    private void OnBecameInvisible()
    {
        Invisible();
    }

    string Invisible()
    {
        var o = gameObject;
        var position = twin.transform.position;
        transform.position = position+_change;
        o.name = transform.position.ToString();
        return "Void";
    }
}
