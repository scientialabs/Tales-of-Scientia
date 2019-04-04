using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


public class Warp : MonoBehaviour
{
    public GameObject Objetivo;
    public GameObject Mapa;
	

	
    void Awake()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        Assert.IsNotNull(Mapa);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
            other.transform.position = Objetivo.transform.GetChild(0).transform.position;
            Camera.main.GetComponent<MainCámera>().SetBound(Mapa);
        
    }
}
