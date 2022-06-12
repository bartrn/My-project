using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillFan : MonoBehaviour
{
    public float rotateSpeed = 100f;


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        //to make it rotate otherway put - in front of vector3
        //forward to rotate front 
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }
}
