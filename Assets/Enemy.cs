using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public float moveSpe = 2f;

    public Rigidbody2D rigb;
    
    private float health = 1f;

    private WherePlayer wherePlayer;
    private Vector2 DirectionPlayer;

    
    void Awake()
    {
        //Don't need to, we can do it in editor but here just in case
        rigb = GetComponent<Rigidbody2D>();
        wherePlayer = GetComponent<WherePlayer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        updateDir();
        rotation();

        //Movement
        rigb.MovePosition(rigb.position + DirectionPlayer *moveSpe * Time.fixedDeltaTime);
    }

    public void takeDmg(){

        health -= 1;
        if (health <= 0){
            Destroy(gameObject);
        }
    }

    void updateDir(){
        //Again, in player awareness  this is always set to true, we have this here in case we want enemy vision to play a role
        if(wherePlayer.AwarePlayer){
            DirectionPlayer = wherePlayer.DirPlayer;
        }
    }

    //Rotater for square enemy to point to player
    void rotation(){
        //No rotation
        if(DirectionPlayer == Vector2.zero){
            //Nothing to do, end early
            return;
        }
        //Quaternion neededRot = Quaternion.LookRotation(transform.forward,)

        //Rotation
        float zrot = Mathf.Atan2(DirectionPlayer.y, DirectionPlayer.x) * Mathf.Rad2Deg - 90f;
        rigb.rotation = zrot;
    }


}
