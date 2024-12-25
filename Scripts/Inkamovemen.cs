using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inkamovemen : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    
   
    //private Rigidbody2D Rigidbody2D;

    private Animator Animator;
    private float Horizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        Animator.SetBool("Running",Horizontal != 0.0f);

        
        


       
    }
    
}
