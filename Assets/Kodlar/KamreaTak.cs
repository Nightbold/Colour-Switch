using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamreaTak : MonoBehaviour
{
    public Transform hedef; // takip etmesini isteciğimiz nesne 
    void Update()
    {
        if (hedef.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,hedef.position.y,transform.position.z);
        }
    }
}
