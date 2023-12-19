using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrACreditos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Game Over", 5);
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}