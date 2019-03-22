using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPOS : MonoBehaviour
{
    public string Siguiendo;
    public GameObject Jugador;
    public GameObject Fijador;
    public GameObject Camara;
    

    Vector2 Pos;
    void Update()
    {
        float x = 0;
        float y = 0;
        if (Jugador.tag != "PlayerIndoor")
        {
            if (Jugador.tag == "Player")
            {
                 x = Jugador.transform.position.x;
                 y = Jugador.transform.position.y;
                
            }
            if (Jugador.tag == "PlayerLock")
            {
                 x = Jugador.transform.position.x;
                 y = 0;

 
            }
        }
        Pos = new Vector2(x, y);
        Camara.transform.position = Pos;

        /* float X = Jugador.transform.position.x;
        float Y = Jugador.transform.position.y;
        if (Jugador.tag == "PlayerLock")
        {
            Y = Fijador.transform.position.y;
        }           
        Pos = new Vector2(X, Y);

        Siguiendo = "Jugador";
        Camara.transform.position = Pos; */



    }
    
    
}
