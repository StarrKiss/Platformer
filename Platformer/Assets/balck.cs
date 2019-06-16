using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balck : MonoBehaviour
{

    public GameObject tilemap;

    Renderer tilemapRenderer;

     void Start() {
         tilemapRenderer = tilemap.GetComponent<Renderer>();
    }
        void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){

                 
        tilemapRenderer.material.SetFloat("_EffectAmount", 1f);
        }


    }

     void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){

                 
        tilemapRenderer.material.SetFloat("_EffectAmount", 0f);
        }
    }
}
