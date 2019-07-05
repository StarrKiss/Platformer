using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{


    public int checkpointNumber = 0;
    
    Vector3 lastCheckpoint;

    GameObject player;
    
    
    
    

 public void Start() {
        player = GameObject.FindWithTag("Player");
    }
    public void newCheckpoint(Vector3 checkPos){
        lastCheckpoint = checkPos;

        checkpointNumber ++;
    }

    public void Update() {
        
           
            
        
    }

    public void Death(){
            if (checkpointNumber != 0)
            {
               gameObject.SendMessage("Respawn");


                player.transform.position = lastCheckpoint;
            }
    }
    

    
}
