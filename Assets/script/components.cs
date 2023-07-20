using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class components : MonoBehaviour
{

    Light LightTank;
    void Start()
    {
        LightTank = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
        {
            bool stateLigth = LightTank.enabled;
            LightTank.enabled = !stateLigth;
        }
    }
}
