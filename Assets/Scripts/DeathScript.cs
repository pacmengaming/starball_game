using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathScript : MonoBehaviour


{
    public GameObject asteroid;
    Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Death")
            {
                gameObject.transform.position = spawnPoint;
            }

            
        }

    private void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.CompareTag("Checkpoint"))
        {
            spawnPoint = asteroid.transform.position;
            
        }
    }
}
