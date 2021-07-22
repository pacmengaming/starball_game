using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingLoop : MonoBehaviour
{
    [SerializeField]
    private float xSpeed = 8f;

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

        if (newPos.x >= origPos + 5f)
        {
            xSpeed = -1 * Mathf.Abs(xSpeed);
        }

        transform.position = newPos;


        if (newPos.x <= origPos)
        {
            xSpeed = 1 * Mathf.Abs(xSpeed);
        }
        
        
    }
}
