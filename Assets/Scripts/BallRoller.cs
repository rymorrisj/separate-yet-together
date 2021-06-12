using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoller : MonoBehaviour
{
    public int speed;
    public int jump;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            //transform.Rotate(Vector3.forward * -speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            // transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().velocity = new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey("space"))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
        }
    }
}
