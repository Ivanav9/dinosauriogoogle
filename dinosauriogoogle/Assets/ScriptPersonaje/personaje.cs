using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    [SerializeField] float vida;
    [SerializeField] float velocidad;
    [SerializeField] float alturaSalto;
    [SerializeField] float alturaDobleSalto;
    [SerializeField] bool puedeDobleSalto = true;
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioClip[] sonidos;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (ComprobarSuelo.estaEnSuelo)
            {
                rigidbody.AddForce(Vector2.up * alturaSalto);
                puedeDobleSalto = true;
                audiosource.clip = sonidos[0];
                audiosource.Play();
            }
            else if (!ComprobarSuelo.estaEnSuelo && puedeDobleSalto)
            {
                rigidbody.velocity = Vector2.zero;
                rigidbody.AddForce(Vector2.up * alturaSalto);
                puedeDobleSalto = false;
                audiosource.clip = sonidos[1];
                audiosource.Play();
            }
        }
        if (rigidbody.velocity.y > 0.1f || rigidbody.velocity.y < -0.1f)
        {
            animator.SetBool("estaEnSuelo", false);
        }
        else
        {
            animator.SetBool("estaEnSuelo", true);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("agacharse", true);
            
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("agacharse", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Perder")
        {
            GameManager.Instancia.Perder();
            audiosource.clip = sonidos[1];
            audiosource.Play();
        }
    }
}
