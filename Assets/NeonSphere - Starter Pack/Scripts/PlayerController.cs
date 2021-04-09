using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public int speed;
    public int jumpForce;

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveHorizontal, 0, -moveVertical);
        rb.AddForce(movement * speed);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
