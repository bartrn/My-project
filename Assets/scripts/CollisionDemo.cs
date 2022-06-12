using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDemo : MonoBehaviour
{ 
    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("OWWW");

            light.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            light.SetActive(false);
        }
    }
}
