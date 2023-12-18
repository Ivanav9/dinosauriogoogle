using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int puntuacionActual, mejorPuntuacion;
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
