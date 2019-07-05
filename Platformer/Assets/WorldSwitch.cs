using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldSwitch : MonoBehaviour
{
 

    public GameObject WorldOne;

    Renderer WorldOneRenderer;

    public GameObject worldTwo;

    Renderer worldTwoRenderer;

    private bool onoff = true;

    private TilemapCollider2D worldTwoCollidor;

    private TilemapCollider2D worldOneCollidor;

    public bool WorldOneHidden;
     

    
    
    


    // Start is called before the first frame update
    void Start()
    {
        WorldOneRenderer = WorldOne.GetComponent<Renderer>();

        worldTwoRenderer = worldTwo.GetComponent<Renderer>();

        worldTwoRenderer.material.SetFloat("_EffectAmount", 1f);
        worldTwoRenderer.material.SetFloat("_AlphaAmount", 0.5f);

        worldTwoCollidor = worldTwo.GetComponent<TilemapCollider2D>();

        worldOneCollidor = WorldOne.GetComponent<TilemapCollider2D>();


        worldTwoCollidor.enabled = false;
        worldOneCollidor.enabled = true;

        WorldOneHidden = false;

         foreach(Transform child in worldTwo.transform){
                        BoxCollider2D childrenCollidor = child.GetComponent<BoxCollider2D>();

                        if (childrenCollidor != null)
                        {
                            childrenCollidor.enabled = false;

                        }


                    }


    }

    

    public void hide(){

         WorldOneRenderer.material.SetFloat("_EffectAmount", 0f);
                    WorldOneRenderer.material.SetFloat("_AlphaAmount", 1f);
                    worldTwoRenderer.material.SetFloat("_EffectAmount", 1f);
                    worldTwoRenderer.material.SetFloat("_AlphaAmount", 0.5f);

                    worldTwoCollidor.enabled = !worldTwoCollidor.enabled;
                    worldOneCollidor.enabled = !worldOneCollidor.enabled;

                    foreach(Transform child in WorldOne.transform){

                        BoxCollider2D childrenCollidor = child.GetComponent<BoxCollider2D>();

                        if(childrenCollidor != null){
                            childrenCollidor.enabled = true;
                        }
                        
                        
                    }

                    foreach(Transform child in worldTwo.transform){
                        BoxCollider2D childrenCollidor = child.GetComponent<BoxCollider2D>();

                        if (childrenCollidor != null)
                        {
                            childrenCollidor.enabled = false;

                        }
                    }

                    WorldOneHidden = false;
    }
    public void show(){
        worldTwoRenderer.material.SetFloat("_EffectAmount", 0f);
                    worldTwoRenderer.material.SetFloat("_AlphaAmount", 1f);

                    WorldOneRenderer.material.SetFloat("_EffectAmount", 1f);
                    WorldOneRenderer.material.SetFloat("_AlphaAmount", 0.5f);

                    worldTwoCollidor.enabled = !worldTwoCollidor.enabled;
                    worldOneCollidor.enabled = !worldOneCollidor.enabled;

                     foreach(Transform child in WorldOne.transform){

                        BoxCollider2D childrenCollidor = child.GetComponent<BoxCollider2D>();

                        if(childrenCollidor != null){
                            childrenCollidor.enabled = false;
                        }
                        
                        
                    }

                    foreach(Transform child in worldTwo.transform){
                        BoxCollider2D childrenCollidor = child.GetComponent<BoxCollider2D>();

                        if (childrenCollidor != null)
                        {
                            childrenCollidor.enabled = true;

                        }
                    }

                    WorldOneHidden = true;


    }


    // Update is called once per frame
     void Update()
    {
         if (Input.mouseScrollDelta.y > 0){

                onoff = !onoff;

                if(onoff){
                   
                    hide();

                } 

                else
                {
                    
                    show();


                }

            }

            if (Input.mouseScrollDelta.y < 0){

                onoff = !onoff;

               
                if(onoff){
                   
                    hide();

                } 

                else
                {
                    
                    show();


                }

            }
    }
}
