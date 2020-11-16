using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGoal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Increase Score Player2
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().increaseScorePlayer2();

            //reset ball position to zero
            other.gameObject.transform.position = Vector2.zero;
        }
    }
}
