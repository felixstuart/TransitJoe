using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;

    public float acceleration;
    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime * acceleration;
        transform.position +=
            new Vector3(1.25f*speed, 0.625F*speed, 0);
    }
}
