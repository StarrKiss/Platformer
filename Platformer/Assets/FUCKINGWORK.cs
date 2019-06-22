using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;


[CreateAssetMenu]

public class FUCKINGWORK : TileBase
{
public Sprite main;

public GameObject Prefab; //The gameobject to spawn

    public override void GetTileData(Vector3Int location, ITilemap tilemap, ref TileData tileData)
    {
        
        tileData.sprite = main;
                tileData.gameObject = Prefab; // Assigning prefab
        

    }

      public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
    {
        // Streangly the position of gameobject starts at Left Bottom point of cell and not at it center
                       
        return base.StartUp(position, tilemap, go);
    }
      
}
