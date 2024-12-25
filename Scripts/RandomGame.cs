using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomGame : MonoBehaviour
{
    // Start is called before the first frame update
    int random;
    public void BotonRandom()
    {
        random = Random.Range(4,8);
        SceneManager.LoadScene(random);
    }
}
