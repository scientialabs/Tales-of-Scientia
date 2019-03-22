using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXTERIOR : MonoBehaviour
{
    public bool Colision;
    void Awake()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerIndoor" || other.tag == "PlayerLock")
        {
            Colision = true;
            other.gameObject.tag = "Player";
        }
    }
}
