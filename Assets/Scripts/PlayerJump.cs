using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private bool isOnFloor;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public float jumpForce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnFloor)
        {
            rb.velocity = Vector2.up * jumpForce;
            isOnFloor = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            if (gameObject.name == "BlobCore")
            {
                isOnFloor = true;
            }
        }
    }
}
