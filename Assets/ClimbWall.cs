using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbWall : MonoBehaviour
{

    public Rigidbody rb;
   

    private bool gravityIsOn = true;
   
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


   void FixedUpdate()
   {
       rb.useGravity = gravityIsOn;
       
   }

    public float climbAngle = 45;
    
    private float getMinClimbAngle()
    {
        return 90f - (climbAngle / 2f);
    }

    private float getMaxClimbAngle()
    {
        return 90f + (climbAngle / 2f);
    }
    
    

    void OnCollisionStay(Collision collision)
    {
        Vector3 worldUp = Vector3.up;

        foreach(var C in collision.contacts)
        {
            Vector3 dir = C.point - transform.position;
            float angle = Vector3.Angle(worldUp, dir);

            Debug.Log(angle);

            if (angle > getMinClimbAngle() && angle < getMaxClimbAngle())
            {
                gravityIsOn = false;
            }

            else
            {
                gravityIsOn = true;
            }
        }



    }

    private List<GameObject> collisions = new List<GameObject>();
    

    void OnCollisionEnter (Collision collision)
    {
        if (collisions.Contains(collision.gameObject) == false)
        {
            collisions.Add(collision.gameObject);
        }

    }

    void OnCollisionExit (Collision collision)

    {
        collisions.Remove(collision.gameObject);

        if (collisions.Count <= 0)
        {
            gravityIsOn = true;
        }
    }



}
