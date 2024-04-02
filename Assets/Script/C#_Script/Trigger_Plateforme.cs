using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Trigger_Plateforme : MonoBehaviour
{
    private GameObject Player;
    private Vector3 Plat_Pos;
    
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Plat_Pos = transform.position;
    }
    void FixedUpdate()
    {
        if (Plat_Pos.y > Player.transform.position.y)
        {
            GetComponent<BoxCollider>().isTrigger = true; 
        }
        else
        {
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }
   
}