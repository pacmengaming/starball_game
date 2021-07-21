using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
     [SerializeField]
    private float SpeedRotation = 100f;

    private void OnTriggerEnter(Collider other)
    {
        MoveBall component = other.gameObject.GetComponent<MoveBall>();
        if (component != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Update()
    {
        RotateGoal();
    }



    private void RotateGoal()
    {
        
        Vector3 rot = transform.rotation.eulerAngles;

        
        
        rot.y = rot.y + (SpeedRotation * Time.deltaTime);
        
        
       
        transform.rotation = Quaternion.Euler(rot);
    }
}
