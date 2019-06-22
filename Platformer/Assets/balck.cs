using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balck : MonoBehaviour
{

    public GameObject tilemap;

    Renderer tilemapRenderer;

    float actualChange;

    float smoothTime = 2f;

    

     void Start() {
         tilemapRenderer = tilemap.GetComponent<Renderer>();
    }
        void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){

                 
                float newPosition = Mathf.SmoothDamp(0f, 1f, ref actualChange, smoothTime);
                tilemapRenderer.material.SetFloat("_EffectAmount", newPosition);



       


        }


    }

     void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){

        
            float newPosition = Mathf.SmoothDamp(0f, 1f, ref actualChange, smoothTime);
            tilemapRenderer.material.SetFloat("_EffectAmount", newPosition);

        }
    }


     void Update() {

            if (Input.mouseScrollDelta.y > 0){
                Debug.Log("scrolling in");

            }

    }
}
