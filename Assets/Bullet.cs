using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Collision
    void OnCollisionEnter2D(Collision2D collision){
        //Information of what collide with
        //eg collision.collider

        Destroy(gameObject);

    }

    
}
