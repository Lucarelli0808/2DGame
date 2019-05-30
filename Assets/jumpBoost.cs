using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBoost : MonoBehaviour
{
    public float JumpForce = 1200;
    bool isJumping;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.CompareTag("superJump")) 

        {

            if (Input.GetKeyDown(KeyCode.UpArrow) && !isJumping)
            {
                isJumping = true;
                rb.AddForce(new Vector2(rb.velocity.x, JumpForce));
            }

        }

    }
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
    }

}
