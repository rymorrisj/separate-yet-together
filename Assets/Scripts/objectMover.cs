using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMover : MonoBehaviour
{
    public GameObject Button;
    public int movespeed;
    public bool moved = false;
    public float minX;
    public float maxX;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Button.GetComponent<MoverButton>().activated == true)
        {
            if (gameObject.transform.position.x > minX)
            {
                transform.position += Vector3.left * movespeed * Time.deltaTime;
            }
        }
        if (Button.GetComponent<MoverButton>().activated == false)
        {
            if (gameObject.transform.position.x < maxX)
            {
                transform.position += Vector3.right * movespeed * Time.deltaTime;
            }
        }

    }
}
