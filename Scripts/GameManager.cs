using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool win;
    public Renderer fondo;
    public GameObject volcan;
    public Rigidbody2D rbVolcan;

    public GameObject plataforma;

    public GameObject contador;
    public Timer tiempo;

    public GameObject contaMonedas;
    public Juegador contadorMonedas;

    public float moverAbajo;
    // Start is called before the first frame update
    void Start()
    {
        rbVolcan = volcan.GetComponent<Rigidbody2D>();
        tiempo = contador.GetComponent<Timer>();
        contadorMonedas = contaMonedas.GetComponent<Juegador>();
        win = false;
        moverAbajo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        moverFondo();
        terminarJuego();
    }
    private void moverFondo(){
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset+new Vector2(0,0.015f)*Time.deltaTime;
        moverAbajo = moverAbajo - 1 * Time.deltaTime;
        rbVolcan.velocity = new Vector2(0.05f*Time.deltaTime,0);
    }

    public void terminarJuego()
    {
        if(tiempo.finJuego || contadorMonedas.finJuego)
        {
            if(contadorMonedas.numeroMonedas == 0){
                win = true;
                Debug.Log("gano");
            }
            Debug.Log("Termino el Juego");
        }
    }
}
