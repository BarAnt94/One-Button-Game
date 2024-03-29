using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Trigger_Plateforme : MonoBehaviour
{
    public Rigidbody rb;
    void FixedUpdate()
    {
        if (transform.position.y > GameObject.FindGameObjectWithTag("Player").transform.position.y)
        {
            GetComponent<BoxCollider>().isTrigger = true; 
        }
        else 
        {
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }   
}