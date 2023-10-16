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

        //Checking if has enemy component we have created
        //It'll be empty if it does not have enemy component
        Enemy other = collision.gameObject.GetComponent<Enemy>();
        if (other ){
            other.takeDmg();
        }

    }

    
}
