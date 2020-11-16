using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float playerVelocity;
    public bool player1;
    public bool player2;

    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player1 == true)
        {
            player1Movement();
        }

        if(player2 == true)
        {
            player2Movement();
        }
    }

    // Metodo para movimentar o jogador 1
    public void player1Movement()
    {
        //limit of position Y
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        //up
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * playerVelocity  * Time.deltaTime);
        }

        //down
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * playerVelocity  * Time.deltaTime);
        }
    }

    // Metodo para movimentar o jogador 2
    public void player2Movement()
    {
        //limit of position Y
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        //up
        if(Input.GetKey(KeyCode.UpArrow))
        {
             transform.Translate(Vector2.up * playerVelocity  * Time.deltaTime);
        }

        //down
        if(Input.GetKey(KeyCode.DownArrow))
        {
             transform.Translate(Vector2.down * playerVelocity  * Time.deltaTime);
        }
    }
}
