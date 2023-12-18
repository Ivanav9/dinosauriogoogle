using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class movimientopersonaje3 : MonoBehaviour
{
    [SerializeField] Vector3 posicionincial;
    [SerializeField] Vector3 posicionMinima;
    [SerializeField] Camera camara;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionincial = transform.position;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionincial;
           velocidad += 1;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Perder")
        {
            //GameManager.Instancia.reiniciarNivel();
            //transform.position = posicionincial;

        }
    }
}

   


    