using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bouncing_Plateforme : MonoBehaviour
{
    public float bounceForce = 1f;
    public Vector3 Direction;
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifie si l'objet entrant est le joueur
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Applique une force de rebondissement vers le haut
                rb.AddForce(Direction * bounceForce, ForceMode.Impulse);
            }
        }
    }
}
