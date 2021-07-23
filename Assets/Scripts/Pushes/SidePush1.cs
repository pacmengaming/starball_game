using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidePush1 : MonoBehaviour
{

    float xSpeed = 5f;

    float origPos;
    Vector3 newPos;




    void Start()
    {
        origPos = transform.position.x;
    }

    
    void Update()
    {
        newPos = transform.position;
        newPos.x += (xSpeed * Time.deltaTime);

        if (newPos.x >= origPos + 4f)
        {
            xSpeed = -4f;
        }

        transform.position = newPos;


        if (newPos.x <= origPos)
        {
            xSpeed = 5f;
        }
        
        
    }
}
