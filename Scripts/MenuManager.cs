using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    // Update is called once per frame
    public void BotonSalir()
    {
        Debug.Log("Saliste d ela aplicacion");
        Application.Quit(); 
    }
}
