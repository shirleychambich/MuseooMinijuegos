using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conejo : MonoBehaviour
{
   // public GameObject Conej;
    // Start is called before the first frame update
    void Start()
    {
          InvokeRepeating("Desplazar",2f, 2f);
    }

    // Update is called once per frame
     private void Desplazar()
    {
         float posX=Random.Range(-9.0f, 10.0f);
         float posY=Random.Range(-5.0f, 0.0f);
        Vector3 posicion = transform.position;
        Debug.Log("posicion conejo"+ posicion);
         posicion.x = posX;
         posicion.y = posY;
        transform.position = posicion;
    }
}
