using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipalManager : MonoBehaviour
{

    public void BotonMuseoCatolica()
    {
        SceneManager.LoadScene("MuseoCatolica");
    }

 
    public void BotonSalir()
    {
        Debug.Log("Saliste d ela aplicacion");
        Application.Quit(); 
    }
}
