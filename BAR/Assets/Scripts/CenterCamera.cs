using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCamera : MonoBehaviour
{
    public GameObject Camara;

    Vector2 Pos;
    void Awake()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    
    {
        float X = gameObject.transform.position.x;
        float Y = gameObject.transform.position.y;
        Pos = new Vector2(X, Y);
        Camara.transform.position = Pos;
        other.gameObject.tag = "PlayerIndoor";
    }

   
}
