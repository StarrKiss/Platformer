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
        if (Input.GetKeyDown("space"))
        {   
            if (checkpointNumber != 0)
            {
                player.transform.position = lastCheckpoint;
            }
            
        }
    }


    
}
