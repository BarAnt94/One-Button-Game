using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float m_jumpForce = 20;
    public bool IsJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(5, 0, 0), ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")&& !IsJumping)
        {
            rb.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
            IsJumping = true;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            IsJumping = false;
        }
        
    }
}
