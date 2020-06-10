using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public float cameraDistance = 30.0f;

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            return;
        }
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}