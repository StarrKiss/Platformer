using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public float gravityAmount = 9.81f;
     Rigidbody rb;


  public void Start(){
    rb = GetComponent<Rigidbody>();
  }

   public void FixedUpdate() {

       rb.AddForce(transform.up * -gravityAmount);

   }
}
