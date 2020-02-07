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
    {
       float horizontal = Input.GetAxis("Horizontal");
       transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * vertical * Time.deltaTime * speed);

       
      

        
    }
    
}
