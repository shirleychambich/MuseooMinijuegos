using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float impulse=150f;
    private Rigidbody2D rb;
  public ControladorEscena controladorEscena; 
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButtonDown(0))

      {
       /*rb.velocity=Vector2.up*velocity; */
      rb.AddForce(transform.up * impulse, ForceMode2D.Impulse);
      } 
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        controladorEscena.Perdiste();
    }
}
