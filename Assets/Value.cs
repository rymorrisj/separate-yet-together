using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    public int value;
    public void SetValue(int newValue)
    {
        value = newValue;
    }

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(11, 12);
        Physics2D.IgnoreLayerCollision(11, 13);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<BlobMass>().GainMass(value);
        }
    }
}
