using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpBall : MonoBehaviour
{

    float jumpSpeed = 5f;
    private Rigidbody rigidBody;
    public bool onGround = true;
    public float thresholdJS = -35f;
    public bool onJP = false;

    
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

        if (transform.position.y < thresholdJS)
        {
            gameObject.tag = "Untagged";
            jumpSpeed = 5f;
            onJP = false;
            
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        onGround = true;

        if (collision.gameObject.tag == "JumpPad")
        {
            jumpSpeed = 25f;
            onJP = true;
        }

        if (collision.gameObject.tag == "Ground")
        {
            jumpSpeed = 5f;
            onGround = true;
        }

        if (collision.gameObject.tag == "Regular")
        {
            jumpSpeed = 5f;
            onJP = false;
        }
        
        
    }

    

}
