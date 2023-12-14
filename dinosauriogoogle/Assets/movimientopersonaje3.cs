using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientopersonaje3 : MonoBehaviour
{
    [SerializeField] Vector3 posicionincial;
    [SerializeField] Vector3 posicionminima;
    [SerializeField] Camera camara;
    [SerializeField] float velocidad; 
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionincial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }
}
