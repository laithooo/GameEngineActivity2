using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody rb;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveInput * moveSpeed, rb.velocity.y, rb.velocity.z);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        rb.velocity = new Vector3(moveInput * moveSpeed, rb.velocity.y, rb.velocity.z);
    }
}
