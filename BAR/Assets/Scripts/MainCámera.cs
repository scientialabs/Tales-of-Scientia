using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCámera : MonoBehaviour
{
    Transform Target;
   void Awake()
    {
        Target = GameObject.FindGameObjectsWithTag("Player").Transform;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
