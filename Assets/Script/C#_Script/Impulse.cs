using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float m_jumpForce = 10;
    public Vector3 Direction;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.AddForce(Direction* m_jumpForce, ForceMode.Impulse);
        }
               
    }
}
