using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float moveSpe = 5f;

    public Rigidbody2D rigb;
    public Camera camera;

    Vector2 movement;
    Vector2 mousePos;
    


    // Update is called once per frame
    void Update()
    {
        //get input for keys
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //get mouse pos for aiming
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

    }

    // Actually moving based on input gotten
    void FixedUpdate(){
        //Movement
        rigb.MovePosition(rigb.position + movement *moveSpe * Time.fixedDeltaTime);

        //rotate char
        Vector2 lookDirection = mousePos - rigb.position;
        float zrot = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;

        rigb.rotation = zrot;

        
    }


}
