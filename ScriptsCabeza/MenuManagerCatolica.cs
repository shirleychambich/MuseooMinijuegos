using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerCatolica : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonSalir()
    {
        SceneManager.LoadScene("MuseoCatolica");
    }
}
