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
    public int bulletMassCost = 1;

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
    }
    void fireBullet(Vector2 direction, float angle)
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

        GetComponent<BlobMass>().LoseMass(bulletMassCost);
    }

    private Vector3 GetWorldPosition(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        worldPosition.z = 0f;
        return worldPosition;
    }
}
