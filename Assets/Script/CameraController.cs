using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    float smoothing = 0.2f;

    void Start()
    {
        this.player = GameObject.Find("Player");
        float smoothing = 0.2f;
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
    }
}