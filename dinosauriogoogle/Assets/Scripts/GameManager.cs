using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    public int puntuacionActual, mejorPuntuacion;
    public GameObject texto, boton;
    public GameObject guardarJugador, guardarEnemigo;
    public bool cronometro;
    // Start is called before the first frame update
    void Start()
    {
        mejorPuntuacion = PlayerPrefs.GetInt("mejorPuntuacion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reset()
    {
        puntuacionActual = 0;
    }


    public void Perder()
    {
        
    }
    public void SumarPunto()
    {
        puntuacionActual += 1;
        if (puntuacionActual >= mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", mejorPuntuacion);
        }
    }
}
