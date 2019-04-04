using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCámera : MonoBehaviour
{
    Transform Objetivo;
    
    float tLX, tLY, bRX, bRY;
   void Awake()
    {
        Objetivo = GameObject.FindGameObjectWithTag("Player").transform;

    }
    
    void Update()
    {
        
          transform.position = new Vector3(
          Mathf.Clamp(Objetivo.transform.position.x,tLX, bRX),
          Mathf.Clamp(Objetivo.transform.position.y, bRY, tLY),
          transform.position.z
          );
        
    }

    public void SetBound(GameObject Map)
    {
        Tiled2Unity.TiledMap config = Map.GetComponent<Tiled2Unity.TiledMap>();
        float CameraSize = Camera.main.orthographicSize;

        tLX = Map.transform.position.x + CameraSize;
        tLY = Map.transform.position.y - CameraSize;
        bRX = Map.transform.position.x + config.NumTilesWide - CameraSize;
        bRY = Map.transform.position.y - config.NumTilesHigh + CameraSize;
    }

}
