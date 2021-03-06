using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public void NoHealth(GameObject type)
    {
        if (type.tag == "Player")
        {
            // TODO trigger animation
            // restart scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (type.tag == "Enemy")
        {
            GameObject massToDrop = GetComponent<BlobMass>().DropMass();
            Vector3 enemyPosition = gameObject.transform.position;
            massToDrop.transform.position = enemyPosition;
            Destroy(gameObject);
        }
    }
}
