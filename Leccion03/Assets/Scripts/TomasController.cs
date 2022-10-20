using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 14/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class TomasController : MonoBehaviour
{
    private Rigidbody playerRb; //Se crea esta variable para usar el Rigidbody del personaje o jugador
    public float jumForce = 10; //Se crea una variable para poder modificar la cantidad de fuerza que queremos
    public float gravityModifier; //Se crea una variable para poder hacer uso y modificacion de la gravedad
    public bool isOnGround = true; //Esta variable es para comprobar que el jugador toque el suele
    public bool gameOver = false;//Variable para finaizar el juego
    private Animator playerAnim;// Variable para las animaciones del jugador
    

    // Start is called before the first frame update
    void Start()
    {
        /*Aqui usamos la variable para acceder al Rigidbody ya que ese objeto no se encuentra en todos
        y usamos el GetComponente para eso*/
        playerRb = GetComponent<Rigidbody>();

        /**/
        playerAnim = GetComponent<Animator>();

        /* Aqui conseguismos toda la fisica de la gravedad que se usa en Unity */
        Physics.gravity *= gravityModifier;

        /*Aqui se aplica la fuerza para el salto con el addForce y es algo similar al TransForm.Translate*/
        //playerRb.AddForce(Vector3.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        /* Creamos una condicion que se usa para que cuando el jugador precione espacio realize un salto
        se hace uso del ForceMode que nos permite aplicar diversas fuerzas*/
        if (Input .GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumForce, ForceMode.Impulse);
            //Aqui se pone en falso ya que se aplica despues de hacer el salto y evita que salte dos veces y salga el jugador volando
            isOnGround = false;

            /**/
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    /**/
    private void OnCollisionEnter(Collision collision)
    {
        /*Hacemos una condicion para el momento en el que el jugador coliciones con un obstaculo*/
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over...!!!");//Mensaje para cuando termine el juego
            playerAnim.SetBool("Death_b", true);//Animacion para el gameOver
            playerAnim.SetInteger("DeathType_int", 1);//Se pone que animacion usar o el tipo
        }
    }
}
