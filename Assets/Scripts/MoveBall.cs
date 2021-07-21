using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    public Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10f;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    } 

    void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(horizontalInput, 0.0f, verticalInput) * speed);
    }

    private void FakePhysics()
    {
        //Change direction faster
            //Rigidbody.velocity
                //Directional vector
                    // Confu
        //Prevent the stop of the ball when changing the direction
    }
}
