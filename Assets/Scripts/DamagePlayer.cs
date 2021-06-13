using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public int damage = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = collision.gameObject;
            if (player.name == "BlobPoints")
            {
                player.GetComponentInParent<BlobMass>().LoseMass(damage);
            }
            else
            {
                player.GetComponent<BlobMass>().LoseMass(damage);
            }
        }
    }
}
