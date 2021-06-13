using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(8, 7);
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");

        Vector2 force = new Vector2(moveInput * speed, rb.velocity.y);
        rb.AddForce(force, ForceMode2D.Force);
    }
}
