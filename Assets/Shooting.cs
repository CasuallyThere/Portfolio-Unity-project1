using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //Bullet and bullet spawn
    public Transform bulletSpawn;
    public GameObject bulletPrefab;

    public float bulletSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        //Get input
       if (Input.GetButtonDown("Fire1")){

        Fire();
       }
    }

    void Fire(){
        //Create bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        //Get rigid body component
        Rigidbody2D rigb = bullet.GetComponent<Rigidbody2D>();
        //Give force
        rigb.AddForce(bulletSpawn.up * bulletSpeed, ForceMode2D.Impulse);

    }
}
