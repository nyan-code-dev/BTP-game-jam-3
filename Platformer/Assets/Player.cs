using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private int jumpsLeft;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && jumpsLeft > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            if(jumpsLeft == 2)
                jumpsLeft--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpsLeft = 2;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        jumpsLeft = 1;
    }
}
