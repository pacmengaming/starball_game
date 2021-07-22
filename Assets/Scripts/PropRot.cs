using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropRot : MonoBehaviour
{
    [SerializeField]
    private float SpeedRotation = 100f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateProp();
    }

    private void RotateProp()
    {
        Vector3 rot = transform.rotation.eulerAngles;

        
        
        rot.z = rot.z + (SpeedRotation * Time.deltaTime);
        
        
       
        transform.rotation = Quaternion.Euler(rot);
    }
}
