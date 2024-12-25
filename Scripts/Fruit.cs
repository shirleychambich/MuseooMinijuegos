using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
     private Rigidbody2D rb;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
       rb.velocity = new Vector2(0f, -speed);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other) {
         Destroy(this.gameObject);
         //Destroy(other.gameObject);
     }
    
}
