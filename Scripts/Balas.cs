using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField]
    private GameObject bala;

    
   
    void Start()
    {
         InvokeRepeating("Disparar",2.0f, 0.5f);
    }

    // Update is called once per frame
    
    private void Disparar()
    {
        GameObject b=Instantiate(bala,transform.position ,transform.rotation);
            b.SetActive(true);
          float rango=Random.Range(-100.0f, -5.0f);
           // Debug.Log(rango);
            b.GetComponent<Rigidbody2D>().AddForce(new Vector3(rango,50),ForceMode2D.Impulse);
            Destroy(b,2);
    }
   

}
