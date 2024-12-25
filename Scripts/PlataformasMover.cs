using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMover : MonoBehaviour
{
    public float velocidad;

    public GameObject plataformas;
    public Rigidbody2D rb;
    // Start is called before the first frame update

    public GameObject empezar;

    public Timer inicio;
    void Start()
    {
        empezar = GameObject.Find("Cuenta");
        rb = plataformas.GetComponent<Rigidbody2D>();
        inicio = empezar.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        iniciarMovimiento();
        
    }
    public void iniciarMovimiento(){
        if(inicio.iniciarJuego){
            
            rb.constraints = RigidbodyConstraints2D.FreezeRotation |  RigidbodyConstraints2D.FreezePositionX;
            //rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.velocity = new Vector2(0,velocidad*Time.deltaTime*(-1));
        }else{
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
