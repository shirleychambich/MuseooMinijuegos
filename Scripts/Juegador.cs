using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Juegador : MonoBehaviour
{

    public bool finJuego;
    public float numeroMonedas;
    private Animator animator;

    public float fuerzaSalto;

    private bool enSuelo;
    public float fuerzaMover;

    public Text contador;

    float velX;
    float velY;
    private Rigidbody2D rigidbody2D;

    public GameObject sonidoSalto;
    public GameObject sonidoMoneda;
    // Start is called before the first frame update
    void Start()
    {
        finJuego = false;
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        numeroMonedas = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && enSuelo){
            Instantiate(sonidoSalto);
            animator.SetBool("estaSaltando", true);
            rigidbody2D.AddForce(new Vector2(0,fuerzaSalto));
            enSuelo = false;
        }
        if(numeroMonedas == 0){
            finJuego = true;
        }
    }
    private void FixedUpdate()
    {
        Mover();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Suelo")
        {
            animator.SetBool("estaSaltando",false);
            enSuelo = true;
        }

        if(collision.gameObject.tag == "Moneda"){
            Debug.Log("Tocando Moneda");
            Instantiate(sonidoMoneda);
            numeroMonedas = numeroMonedas-1;
            actualizarCuentaMoneda(numeroMonedas);
            Destroy(collision.gameObject,.5f);
        }
        if(collision.gameObject.tag == "Perder"){
            finJuego = true;
        }
    }

    public void Mover(){
        velX = Input.GetAxisRaw("Horizontal");
        velY = rigidbody2D.velocity.y;

        rigidbody2D.velocity = new Vector2(velX*fuerzaMover,velY);
    }
    private void actualizarCuentaMoneda(float num){
        contador.text = ""+(int)num;
    }
    public void Saltar(){

    }


}
