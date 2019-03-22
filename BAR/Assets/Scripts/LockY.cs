using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockY : MonoBehaviour
{
    public GameObject Camara;

    Vector2 Pos;
    public GameObject Jugador;
    void Awake()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "PlayerIndoor")
        {
            other.gameObject.tag = "PlayerLock";
        }
    }


}
