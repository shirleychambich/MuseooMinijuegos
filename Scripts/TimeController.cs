using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int min,seg;
     
   [SerializeField] Text tiempo;
       public GameObject condor;
 
    private float restante;
    private bool enMarcha;

    private void Awake() {
        restante = (min * 60) +seg;
        enMarcha = true;

    }

    // Update is called once per frame
    void Update()
    {
       
        if(enMarcha){
            restante -=Time.deltaTime;
            if(restante<1){
                enMarcha = false;
              
               if(condor.GetComponent<Jugador>().vida>0){
               
                    condor.GetComponent<Jugador>().win=true;
                    Debug.Log("GANASTE");
                    #if UNITY_EDITOR
             // Application.Quit() does not work in the editor so
             // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
             UnityEditor.EditorApplication.isPlaying = false;
         #else
             Application.Quit();
         #endif
                     Debug.Log("salio del juego");
               }
              
            }
            int tempMin = Mathf.FloorToInt(restante/60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}" , tempMin , tempSeg);
            
        }
    }
}
