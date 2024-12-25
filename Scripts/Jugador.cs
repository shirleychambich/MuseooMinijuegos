using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] 
  public  int vida;
    [SerializeField] 
    int maximoVida;

 

  [SerializeField] 
   public bool win;
      public GameObject barraVida;
    public Sprite vida3,vida2,vida1,vida0;

 

 // public GameObject time;
    void Start()
    {
           vida=maximoVida;
         //  win=false;
         actualizarBarraVida();
    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("BalaEnemigo")){
            TomarDaño(1);
            Debug.Log("choca con condor");
        }
        if(other.CompareTag("Conejo")){
            Destroy(other.gameObject);
            Curar(1);
            Debug.Log("Atrapa al conejo");
        }
    }
    public void actualizarBarraVida(){
        Debug.Log("actualizé la barra");
        if(vida==7){
            barraVida.GetComponent<Image>().sprite=vida3;
        }
        if(vida==4){
             barraVida.GetComponent<Image>().sprite=vida2;
        }
        if(vida==1){
             barraVida.GetComponent<Image>().sprite=vida1;
        }
        if(vida==0){
             barraVida.GetComponent<Image>().sprite=vida0;
        }
    }

    public void Curar(int curacion){
          Debug.Log("ingresa a curar");
        if((vida+curacion)>maximoVida){
            vida=maximoVida;
        }else{
            vida+=curacion;
        }
        actualizarBarraVida();
        
    }
     public void TomarDaño(int daño)
    {
        Debug.Log("ingresa a daño");
         vida-=daño;
        if(vida<=0){
          //  Destroy(gameObject);
            win=false;
             Debug.Log("PERDIÓ");

             SceneManager.LoadScene("MuseoCatolica");
        }
        actualizarBarraVida();

    }

}
