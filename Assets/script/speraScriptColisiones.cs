using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speraScriptColisiones : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        // Debug.Log("el obj Collision con algo");
        if(other.collider.CompareTag("Ground"))
        {
            Debug.Log("Collision con el ground");
        }
        
    }
    public void OnCollisionStay(Collision other)
    {
        if(other.collider.CompareTag("Ground"))
        {
            Debug.Log("estoy collisionado con el ground");
        }
        
    }

    private OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ground"))
        {
            Debug.Log("a travezado ")
        }
    }

}
