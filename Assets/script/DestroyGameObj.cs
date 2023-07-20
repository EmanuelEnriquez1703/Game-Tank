using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObj : MonoBehaviour
{

    public float time;
    public GameObject esfera;
    private void OnMouseDown(){
        Debug.Log("hiciste click sobre un game object con collider");
        // Destroy(gameObject,time);
        Destroy(esfera,time);
    }   
}
