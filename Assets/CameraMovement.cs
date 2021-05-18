using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    public float offset;
    // Update is called once per frame
    void LateUpdate()
    {
        var transformPosition = transform.position;
        transformPosition.x = player.position.x + offset;
    }
}
