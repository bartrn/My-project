using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveWhenClose : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            anim.SetTrigger("wave");//name of box collider to trigger
        }
    }

    // drag this file to the character to trigger effects
}
