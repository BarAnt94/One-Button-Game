using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float m_jumpForce = 10;
    public bool IsJumping = false;
    public AudioSource audioSource;
    public AudioClip jumpSound; // Son à jouer lors du saut
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(0, 0, 0), ForceMode.Force);
        audioSource.clip = jumpSound; // Attribution du son à l'AudioSource
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")&& !IsJumping)
        {
            rb.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
            IsJumping = true;  
            audioSource.Play(); // Joue le son
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
