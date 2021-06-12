using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private int blobMass;
    private int numJumps;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        blobMass = GetComponent<BlobMass>().mass;
        numJumps = 1;
    }
    public float jumpForce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
