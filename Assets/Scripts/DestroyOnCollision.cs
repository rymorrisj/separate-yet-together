using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class DestroyOnCollision : MonoBehaviour
    {
        private void Start()
        {
            Physics2D.IgnoreLayerCollision(8, 9);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
        }
    }
}
