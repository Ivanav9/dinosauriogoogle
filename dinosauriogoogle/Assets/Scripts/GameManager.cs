using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int puntuacionActual, mejorPuntuacion;
    [SerializeField] float tiempo = 120;
    [SerializeField] TMP_Text texto;
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
        texto.text = textoTiempo;
    }
    public void Reset()
    {
        puntuacionActual = 0;
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
