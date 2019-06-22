using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{

    GameObject gameController;

    WorldSwitch worldSwitch;

    checkpoints checkpoint;

    private bool isTriggered = false;



    void Start() {
        gameController = GameObject.FindWithTag("GameController");
        worldSwitch = gameController.GetComponent<WorldSwitch>();
        checkpoint = gameController.GetComponent<checkpoints>();
    }
    void OnTriggerEnter2D(Collider2D other)
        {
         if(other.gameObject.tag == "Player"){

                 if(worldSwitch.WorldOneHidden == true){

                     if(isTriggered == false){
                         checkpoint.newCheckpoint(transform.position);
                     }
             
                 }
                Debug.Log("hi");


       


            }
        }

    }