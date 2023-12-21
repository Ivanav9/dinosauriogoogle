using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    public int puntuacionActual, mejorPuntuacion;
    public GameObject texto, boton;
    public GameObject guardarJugador, guardarEnemigo;
    [SerializeField] float tiempo = 120;
    [SerializeField] TMP_Text texto2;
    public GameObject guardarenemigo2;
    public enemigoivan _enemigo2;
    // Start is called before the first frame update
    void Start()
    {
        mejorPuntuacion = PlayerPrefs.GetInt("mejorPuntuacion");
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        Debug.Log(minutos + ":" + segundos);
        string textoTiempo = $"{minutos:D2}:{segundos:D2}";
        texto2.text = textoTiempo;
    }
    public void Reset()
    {
        puntuacionActual = 0;
    }


    public void Perder()
    {
       
        
         guardarenemigo2.SetActive(false);
        
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
