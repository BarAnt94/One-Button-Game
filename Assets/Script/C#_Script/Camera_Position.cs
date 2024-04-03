using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Position : MonoBehaviour
{
    private GameObject player;
    private float Camxpos = 0f;
    private float playxpos = 0f;
    private float Camypos = 0f;
    private float playpos = 0f;

    public float MaxY = 0f;
    public float MaxX = 0f;
    public float MinX = 0f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Camypos = gameObject.transform.position.y;
        playpos = player.transform.position.y;
        Camxpos = gameObject.transform.position.x;
        playxpos = player.transform.position.x;
        if (playpos > Camypos + MaxY)
        {
            transform.position = new Vector3(transform.position.x, playpos - MaxY, transform.position.z);
        }
        if (playxpos > Camxpos + MaxX)
        {
            transform.position = new Vector3(playxpos-MaxX, transform.position.y, transform.position.z);
        }
        else if (playxpos < Camxpos - MinX)
        {
            transform.position = new Vector3(playxpos + MaxX, transform.position.y, transform.position.z);
        }
    }
}

