using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveWhenClose : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();//aince trigger is attached to this person would be this object to aniate
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)//add to perosn in which trigger is attached too
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("wave");

            anim.SetTrigger("wave");

            
        }
    }

}
