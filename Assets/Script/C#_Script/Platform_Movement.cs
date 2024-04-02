using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Vitesse de d�placement de la plateforme
    public float moveDistance = 4f; // Distance totale de d�placement

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        // V�rifie si la plateforme a parcouru sa distance maximale
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveDistance)
        {
            movingRight = !movingRight;
        }
    }
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
         other.transform.SetParent(this.transform);
       }
       
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
       {
         other.transform.SetParent(null);
       }
        
       
    }
}
