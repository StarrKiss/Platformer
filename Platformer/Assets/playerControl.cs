using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

     public float glideSpeed;
     private Rigidbody rb;
     private float distanceToGround;
     public float jumpSpeed;

     private GameObject cursorObject;

     public float speed;
     
     public float gravitySpeed;

     private float timeleftglide;

     public float overallglidetime;

     public float glideSubtract;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

        cursorObject = GameObject.Find("cursorPosition");


    }

    // Update is called once per second
    void Update()
    {
      
      cursorMove cursor = cursorObject.GetComponent<cursorMove>();

     Vector3 currentVel = rb.velocity;
     
     currentVel.x = cursor.xMove * speed;
      

      rb.velocity = (currentVel);


       //GroundCheck
       RaycastHit hit = new RaycastHit();
              if (Physics.Raycast (transform.position, -Vector3.up, out hit)) {
                   distanceToGround = hit.distance - 0.5f;


              }




              //gliding
       if(Input.GetButton("Fire2") && distanceToGround != 0 && timeleftglide <= overallglidetime){
          Vector3 vel = rb.velocity;
           vel.y = cursor.yMove * glideSpeed;

         rb.velocity = vel;

         timeleftglide = timeleftglide + Time.deltaTime;

         Vector3 glideVel = rb.velocity;

         glideVel.y -= glideSubtract;

         rb.velocity = glideVel;


       }
       else{

       }
        //jumping
        if(Input.GetButtonDown("Fire1") && distanceToGround < 0.05){
          rb.AddForce(transform.up * jumpSpeed, ForceMode.Impulse);
        }
        if (distanceToGround < 0.05){
          timeleftglide = 0;
        }




          rb.AddForce(transform.up * -gravitySpeed);

        



    }
    
}
