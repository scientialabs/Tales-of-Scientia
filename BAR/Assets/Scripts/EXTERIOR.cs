using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exterior : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTrigger2D(Collider2D other)
    {
        if (other.tag == "PlayerIndoor")
        {
            other.tag = "Player";
        }
    }
}
