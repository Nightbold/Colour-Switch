using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunDurumu : MonoBehaviour
{
   
       void Start()
    {
        Time.timeScale=0f;        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Time.timeScale=1f;
           this.enabled=false;
        }
    }
}
