using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Gen : MonoBehaviour
{
    public GameObject twin;
    private void OnBecameInvisible()
    {
        Invisible();
    }

    string Invisible()
    {
        var o = gameObject;
        var position = twin.transform.position;
        print("In-Visible!");
        transform.position = new Vector3(position.x, position.y + 2f, position.z);
        o.name = transform.position.ToString();
        return "Void";
    }
}
