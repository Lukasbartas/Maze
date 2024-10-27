using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Application.LoadLevel("2");
    }
}
