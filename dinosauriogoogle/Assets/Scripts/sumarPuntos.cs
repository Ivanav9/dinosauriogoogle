using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumarPuntos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider other)
    {
        if (other.transform.tag == "SumarPuntos")
        {
            GameManager.Instancia.SumarPunto();
        }
    }
}