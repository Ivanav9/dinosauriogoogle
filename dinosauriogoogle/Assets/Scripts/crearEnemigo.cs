using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearEnemigo : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionMaxima;
    [SerializeField] bool crear = true;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionMaxima = camara.ViewportToWorldPoint(new Vector2(1, 1));
        StartCoroutine(CrearEnemy());
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public IEnumerator CrearEnemy()
    {
        while (crear)
        {
            GameObject enemyNuevo = Instantiate(enemy);
            enemyNuevo.transform.position = CalcularPosicionAleatoria();
            yield return new WaitForSeconds(Random.Range(2f, 6f));
        }
    }
    public Vector2 CalcularPosicionAleatoria()
    {
        Vector2 posicionAleatoria = new Vector2();
        posicionAleatoria.x = posicionMaxima.x + 1;
        float alturaPantalla = posicionMaxima.y - posicionMinima.y;
        posicionAleatoria.y = -3.05f;
        return posicionAleatoria;
    }
}
