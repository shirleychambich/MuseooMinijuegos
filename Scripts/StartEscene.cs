using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEscene : MonoBehaviour
{
    public string startScene;
    public string menuScene;
    
    public void StartGame(){
        SceneManager.LoadScene(startScene);
    }
    public void MenuGame(){
        SceneManager.LoadScene(menuScene);
    }
    public void QuitGame(){
        Application.Quit();
    }

}
