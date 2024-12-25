using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PersonajeMovement : MonoBehaviour
{

    public AudioClip sound;
    public float Speed;
    public float JumpForce;
    public bool win=false;
    
    public GameObject gameOverImg;
    public GameObject winImg;

    public GameObject spawn;
    //public GameObject Camera;
    private Rigidbody2D Rigidbody2D;

    //private Animator Animator;
    private float Horizontal;
    private bool Grounded;
    // Start is called before the first frame update

    public int score;
    public float temporizador=30f;
    public Text TXTScore;
    public Text TXTemp;
    void Start()
    {
        gameOverImg.SetActive(false);
        winImg.SetActive(false);
        Rigidbody2D = GetComponent<Rigidbody2D>();
        //Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        temporizador -= 1*Time.deltaTime;
        TXTemp.text = " "+temporizador.ToString("0");

        if(temporizador <= 0){
            gameOverImg.SetActive(true);
            Destroy(this.gameObject);
            spawn.SetActive(false);
            Camera.main.GetComponent<AudioSource>().Stop();
            
        }

       

        TXTScore.text = ": "+score;

        if(score == 20){
            winImg.SetActive(true);
            Destroy(this.gameObject);
            spawn.SetActive(false);
            Camera.main.GetComponent<AudioSource>().Stop();
            win=true;
            
        }

        Horizontal = Input.GetAxisRaw("Horizontal");

        if(Horizontal<0.0f) transform.localScale = new Vector3(-1.0f,1.0f,1.0f);
        else if(Horizontal > 0.0f) transform.localScale  =new Vector3(1.0f,1.0f,1.0f);



        //Animator.SetBool("Running",Horizontal != 0.0f);

        
        Debug.DrawRay(transform.position, Vector3.down * 0.5f, Color.red);  
       if(Physics2D.Raycast(transform.position, Vector3.down, 10f)){
           Grounded=true;
       }
       else Grounded=false;


        if(Input.GetKeyDown(KeyCode.W) && Grounded){
           Jump();
       } 
    }
    private void Jump(){
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }
    private void FixedUpdate() {
        Rigidbody2D.velocity = new Vector2(Horizontal*Speed,Rigidbody2D.velocity.y);    
    }

    

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Coin"){
            score++;
            Destroy(other.gameObject);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);
        }
         
         //Destroy(other.gameObject);
     }
     
    
}
