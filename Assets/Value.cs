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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = collision.gameObject;
            if (player.name == "BlobPoints")
            {
                player.GetComponentInParent<BlobMass>().GainMass(value);
            }
            else
            {
                player.GetComponent<BlobMass>().GainMass(value);
            }
            Destroy(gameObject);
        }
    }
}
