using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpBall : MonoBehaviour
{

    private float jumpSpeed = 5f;
    private Rigidbody rigidBody;
    private bool onGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && onGround)
        {
            rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            onGround = false;
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }


}
