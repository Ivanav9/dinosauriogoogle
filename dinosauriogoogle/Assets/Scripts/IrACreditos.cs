using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrACreditos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CambiarEscena", 5);
    }
    void CambiarEscena()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}