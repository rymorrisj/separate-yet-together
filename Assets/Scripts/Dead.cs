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
            Camera gameCamera = Camera.main;
            Vector3 enemyPosition = GetWorldPosition(gameObject.transform.position, gameCamera);
            massToDrop.transform.position = enemyPosition;
        }
    }

    private Vector3 GetWorldPosition(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        worldPosition.z = 0f;
        return worldPosition;
    }
}
