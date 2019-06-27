using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

     public float glideSpeed;
     private Rigidbody2D rb;
     public float jumpSpeed;

     private GameObject cursorObject;

     public float speed;
     
     public float gravitySpeed;

     private float timeleftglide;

     public float overallglidetime;

     public float glideSubtract;

    public LayerMask groundLayer;

    public GameObject gameControl;

    
  
    

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

          Cursor.visible = false;

        cursorObject = GameObject.Find("cursorPosition");


    }

    // Update is called once per second

     bool IsGrounded() {
    Vector2 position = transform.position;
    Vector2 direction = Vector2.down;
    float distance = 1.0f;
    
    RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
    if (hit.collider != null) {
        return true;
    }
    
    return false;



}



    void Update()
    {
      
      cursorMove cursor = cursorObject.GetComponent<cursorMove>();

     Vector3 currentVel = rb.velocity;
     
     currentVel.x = cursor.xMove * speed;
      

      rb.velocity = (currentVel);

        if(transform.position.y < -6.5){

          
        }
      




              //gliding
       if(Input.GetButton("Fire2") && !IsGrounded() && timeleftglide <= overallglidetime){
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
        if(Input.GetButtonDown("Fire1") && IsGrounded()){
          rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
        }
        if (IsGrounded()){
          timeleftglide = 0;
        }


  if (!IsGrounded()){
           rb.AddForce(transform.up * -gravitySpeed);
        }
         
      

        



    }
    
}

