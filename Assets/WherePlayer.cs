using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WherePlayer : MonoBehaviour
{   
    //Indicate whether this object is aware of player, not really needed as alwys chase but what if blind enemy or smth
    public bool AwarePlayer{
        get; 
        private set;
        }


    public Vector2 DirPlayer{
        get; 
        private set;
        }

    //Range of vision, again not needed in what we're doing but useful to remember
    [SerializeField]
    private float VisionRange;

    private Transform player;

    void Awake()
    {
        //only the player will have playermove so we can use that to get transform
        player = FindObjectOfType<playerMove>().transform;

        // just set to always can see for this enemy, turn this off if want vision and stuff
        AwarePlayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        // vision things
        Vector2 direction = player.position - transform.position;
        DirPlayer = direction.normalized;

        // //Use this for player vision
        // if ((direction.normalized).magnitude <= VisionRange){
        //     AwarePlayer = true;
        // }
        // //This one is for moving back out of range
        // else{
        //     AwarePlayer = false;
        // }
    }
}
