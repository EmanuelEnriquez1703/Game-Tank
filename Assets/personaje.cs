using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
        
    public int speed;
    public int turnSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical); 

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontal); 



        // if(Input.GetKey(KeyCode.W))
        // {
        //     transform.Translate(Vector3.forward * speed * Time.deltaTime); 
        // } else if(Input.GetKey(KeyCode.S)) {
        //     transform.Translate(- Vector3.forward * speed * Time.deltaTime); 
        // }

        //transform.Rotate(Vector3.up , trunSpeed * Time.deltaTime);   
    }
}
