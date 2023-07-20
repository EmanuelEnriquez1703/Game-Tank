using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public float time;
    public GameObject spherePrefab;
    public Transform spherePosition;
    void Start()
    {
        // Invoke("CreateSpehere",time);   
        // InvokeRepeating("CreateSpehere",2,1);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            CreateSpehere();
        }   
    }

    void CreateSpehere()
    {
        Instantiate(spherePrefab,spherePosition.position,spherePosition.rotation); 
    }
}
