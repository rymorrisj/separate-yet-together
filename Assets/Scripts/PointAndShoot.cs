using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject player;
    public Camera gameCamera;
    public GameObject crosshairs;
    public GameObject bulletPrefab;
    public GameObject bulletStart;

    public float bulletSpeed = 60.0f;
    public float playerFireSpeed = 180.0f;
    public int bulletMassCost = 1;
    public int playerMassCost = 5;

    private Vector3 target;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = GetWorldPosition(Input.mousePosition, gameCamera);

        Vector3 aimDireciton = (mousePosition - player.transform.position).normalized;
        float angle = Mathf.Atan2(aimDireciton.y, aimDireciton.x) * Mathf.Rad2Deg;

        crosshairs.transform.position = new Vector2(mousePosition.x, mousePosition.y);

        if (Input.GetMouseButtonDown(0))
        {
            float distance = aimDireciton.magnitude;
            Vector2 direction = aimDireciton / distance;
            direction.Normalize();
            fireBullet(direction, angle);
        }

        if (Input.GetMouseButtonDown(1))
        {
            float distance = aimDireciton.magnitude;
            Vector2 direction = aimDireciton / distance;
            direction.Normalize();
            firePlayer(direction, angle, player);
        }
    }
    void fireBullet(Vector2 direction, float angle)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

        GetComponent<BlobMass>().LoseMass(bulletMassCost);
    }

    void firePlayer(Vector2 direction, float angle, GameObject player)
    {
        int lives = GetComponent<BlobMass>().numOfBlobs;
        if (lives <= 1)
        {
            return;
        }

        GameObject newPlayer = Instantiate(player) as GameObject;
        newPlayer.tag = "NewPlayer";

        Physics2D.IgnoreLayerCollision(8, 8);

        newPlayer.transform.position = bulletStart.transform.position;
        newPlayer.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
        newPlayer.GetComponent<Rigidbody2D>().velocity = direction * playerFireSpeed;

        GetComponent<BlobMass>().LoseMass(playerMassCost);

        Camera.main.GetComponent<PlayerControllerSwitcher>().disablePlayer(gameObject);
    }

    private Vector3 GetWorldPosition(Vector3 screenPosition, Camera worldCamera)
    {
        if (worldCamera)
        {
            Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
            worldPosition.z = 0f;
            return worldPosition;
        }
        else
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition); worldPosition.z = 0f;
            return worldPosition;
        }
    }
}
