using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiposDatos : MonoBehaviour
{
    void Start()
    {
        // tipo valor la variable cambia de valor
        Vector3 pos = transform.position;
        pos = new Vector3(1,2,3);

        // tipo referencia 
        Transform trans = transform;
        trans.position = new Vector3(1,2,4);
    }

    void Update()
    {
        
    }
}
