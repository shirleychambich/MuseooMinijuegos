using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public bool iniciarJuego;
    //public UI.text cuenta;
    public bool finJuego;
    public float cuentaRegresiva;
    public float cuentaMoneda;

    public GameObject panel;
    public GameObject titulo;

    public Text textCuentaAtras;
    // Start is called before the first frame update
    void Start()
    {
        iniciarJuego = false;
        cuentaRegresiva = 30;
        cuentaMoneda = 20;
        finJuego = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            destruirPanel();
            iniciarJuego = true;
        }
        if(iniciarJuego){
            cuentaRegresiva = cuentaRegresiva-1 * Time.deltaTime;
            actualizarCuenta(cuentaRegresiva);
        }
        
    }

    public void actualizarCuenta(float num)
    {
        if(num > 0 && num < 31)
        {
            textCuentaAtras.text = ""+(int)num;
        }else
        {
            finJuego = true;
            SceneManager.LoadScene("MuseoCatolica");
        }
    }
    private void destruirPanel(){
        Destroy(panel,.5f);
        Destroy(titulo, .5f);
    }
}
