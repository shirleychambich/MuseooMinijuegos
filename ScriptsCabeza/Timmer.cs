using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timmer : MonoBehaviour
{
   public Text Tempo;
    public float Tiempo = 0.0f;
    public bool DebeAumentar = false;

    void Update() 
    {
        if (DebeAumentar) 
            Tiempo += Time.deltaTime; 
            // Primero se comprueba que sea falso el tener que aumentar.
        else 
        {
            if (Tiempo <= 0.0f)  // Comprueba si es menor o igual a cero.
            { DebeAumentar = true; } // Para volver true a este.
            else 
            { Tiempo -= Time.deltaTime; } // De lo contrario, sigue bajando.
        }
        if (Tiempo <= 30.0f) 
        {} // Comprueba para cambiar el color del text. 
        else { } // Vuelve a verde cuando aumente...

        Tempo.text = "Tiempo:" + " " + Tiempo.ToString ("f0");
    }
}
