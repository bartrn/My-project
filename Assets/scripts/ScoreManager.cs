using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//needed to add this 
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;



    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ScoreItem"))
        {
            float scoreValue = float.Parse(scoreText.text) + other.gameObject.GetComponent<scoreScript>().scoreValue;

            scoreText.text = "" + scoreValue;

            Destroy(other.gameObject);
        }

    }
}
