using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorMove : MonoBehaviour
{
    public float xMove;

    public float yMove;


    // Update is called once per frame
    void Update()
    {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 currentPos = transform.position;
            currentPos.z = -1;
            transform.position = currentPos;



            yMove = transform.localPosition.y;
            xMove = transform.localPosition.x;

            xMove = xMove / 12f;
            yMove = yMove / 5f;

            


    }
}
