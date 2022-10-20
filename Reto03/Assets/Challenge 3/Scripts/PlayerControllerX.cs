using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 14/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    private float limiteArriba = 12; //Se crea una variable para darle limite al globo y no suba de manera infinita
    private bool puedeSubirMas; //Se crea esta variable por si el goblo esta muy abajo pueda elevarse hasta el limite asignado

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip reboteSuelo;//Se agrega esta variable para hacer el sonido al rebotar en la tierra


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();//Agregamos esta linea para poder controlar el goblo 

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        /* Se crea una condicion para comprobar las pocisiones del goblo*/
        if(transform.position.y < limiteArriba)
        {
            puedeSubirMas = true;
        }
        else
        {
            puedeSubirMas = false;
        }

        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && puedeSubirMas)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }
        /* Se crea una condicion para que al momento de que el globo toque el suele hace una especie de rebote */
        else if(other.gameObject.CompareTag("Suelo"))
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            playerAudio.PlayOneShot(reboteSuelo, 1.5f);
        }

    }

}
