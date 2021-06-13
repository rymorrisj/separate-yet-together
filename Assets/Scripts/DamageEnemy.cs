using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public int bulletDamage = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject enemy = collision.gameObject;
            if (enemy.name == "BlobPoints")
            {
                enemy.GetComponentInParent<BlobMass>().LoseMass(bulletDamage);
            }
            else
            {
                enemy.GetComponent<BlobMass>().LoseMass(bulletDamage);
            }
        }
    }
}
