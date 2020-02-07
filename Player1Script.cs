using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour
{

    public float speed;
    public float rightScreenEdge;
    public float leftScreenEdge;
    public float bottomScreenEdge;
    public float topScreenEdge;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   // left right movement
       float horizontal = Input.GetAxis("Horizontal");
       transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        // up down movement
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * vertical * Time.deltaTime * speed);
        
        // this works fine, makes left and right screen edge block player
        if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }

        // problems with this code, should block player from going out of top and bottom of canvas, but 
        // is acting weirdly

        if (transform.position.y < bottomScreenEdge)
        {
            transform.position = new Vector2(bottomScreenEdge, transform.position.x);
        }
        if (transform.position.y > topScreenEdge)
        {
            transform.position = new Vector2(topScreenEdge, transform.position.x);
        }



    }
    
}

