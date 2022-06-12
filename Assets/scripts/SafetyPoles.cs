using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SafetyPoles : MonoBehaviour
{

    private Vector3 startPosition;
    public float moveSpeed = 1f;
    public float moveDistance = 3f;
    private bool reverse = false;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;//start postion of current location
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, startPosition) < moveDistance && !reverse)
        {
            //move from start to end 
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);//moving forward 
            Debug.Log("Move A -> B");

        }

        else if (Vector3.Distance(this.transform.position, startPosition) > 1 && reverse)
        {
            // mover from end to start

            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);//moving forward 
            Debug.Log("Move B -> A");

            // mover from end to start

        }

        else
        {
            reverse = !reverse;
        }


    }
}