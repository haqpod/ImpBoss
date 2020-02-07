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
    void Update() //input left right and up down
    {
       float horizontal = Input.GetAxis("Horizontal");
       transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * vertical * Time.deltaTime * speed);
        
        //left and right sides will block the ball
         if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }

       
      

        
    }
    
}
