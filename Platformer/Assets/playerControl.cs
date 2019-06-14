using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

     public float glideSpeed;
     private Rigidbody rb;
     private float distanceToGround;
     public float jumpSpeed;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per second
    void FixedUpdate()
    {
       //GroundCheck
       RaycastHit hit = new RaycastHit();
              if (Physics.Raycast (transform.position, -Vector3.up, out hit)) {
                   distanceToGround = hit.distance - 0.5f;


              }




              //gliding
       if(Input.GetButton("Jump") && distanceToGround != 0){
          Vector3 vel = rb.velocity;
           vel.y = -glideSpeed;

         rb.velocity = vel;

       }
       else{}
        //jumping
        if(Input.GetButtonDown("Jump") && distanceToGround == 0){
          rb.AddForce(transform.up * jumpSpeed);
        }


    }
}
