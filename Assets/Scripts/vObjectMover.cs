using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vObjectMover : MonoBehaviour
{
    public GameObject Button;
    public int movespeed;
    public bool moved = false;
    public float minY;
    public float maxY;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Button.GetComponent<MoverButton>().activated == true)
        {
            if (gameObject.transform.position.y > minY)
            {
                transform.position += Vector3.down * movespeed * Time.deltaTime;
            }
        }
        if (Button.GetComponent<MoverButton>().activated == false)
        {
            if (gameObject.transform.position.y < maxY)
            {
                transform.position += Vector3.up * movespeed * Time.deltaTime;
            }
        }

    }
}
