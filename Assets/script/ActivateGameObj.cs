using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lightTank;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      if(Input.GetKeyDown(KeyCode.P))
      {
        lightTank.SetActive(!lightTank.activeInHierarchy);
      } 
    }
}
