using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDR : MonoBehaviour
{
    [SerializeField]
    private float ySpeed = 0.25f;

    [SerializeField]
    private float SpeedRotation = 100f;

    


    float origPos;
    Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        
        RotateCheck();

        
        newPos = transform.position;
        newPos.y += (ySpeed * Time.deltaTime);
        
        if (newPos.y >= origPos + 0.5f)
        {
            ySpeed = -1 * Mathf.Abs(ySpeed);
        }

        transform.position = newPos;


        if (newPos.y <= origPos)
        {
            ySpeed = 1 * Mathf.Abs(ySpeed);
        }

        
        
    }

    private void RotateCheck()
    {
        
        Vector3 rot = transform.rotation.eulerAngles;

        
        
        rot.y = rot.y + (SpeedRotation * Time.deltaTime);
        
        
       
        transform.rotation = Quaternion.Euler(rot);
    }

    


}
