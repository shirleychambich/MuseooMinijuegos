using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicaPuntaje : MonoBehaviour
{
    // Start is called before the first frame update
    public static int puntaje=0;
    void Start()
    {
        puntaje=0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text=puntaje.ToString();
    }
}
