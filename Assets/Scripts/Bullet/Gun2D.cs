using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2D : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up* bulletSpeed;

        
        }

    }
}
