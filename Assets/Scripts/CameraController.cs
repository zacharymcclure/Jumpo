using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float offsetY;
    private float offsetZ = -10;

    void Update()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = 0;
        cameraPosition.y = player.position.y + offsetY;
        cameraPosition.z = offsetZ;
        transform.position = cameraPosition;
    }
}
