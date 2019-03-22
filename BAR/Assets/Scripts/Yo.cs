using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yo : MonoBehaviour
{
    public bool Helado;
 
    void OnTriggerEnter2D(Collider2D Dulce)
    {
        if (Dulce.tag == "PlayerLocked")
        {
            
        }
    }
   


   
}
