using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Alumno: Kevin Michelle Chimal Villafuerte
Grupo: GDGS2102-e
Fecha Creacion: 27/Octubre/2022
Carrera: ING. Desarrollo de Software
Materia: Desarollo de Video Juegos
*/

public class PlayerController : MonoBehaviour
{

    //Variable para modificar la velocidad del jugador
    private float speed = 50.0f;

    //Variable tipo Rigidbody
    private Rigidbody playerRb;

    //Variable para controlar el limite del jugador
    private float zBound = 6;

    // Start is called before the first frame update
    void Start()
    {
        //Traemos el componente Rigidbody del jugador para poder usar sus caracteristicas 
          playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //LLamamos a la funcion MovePlayer()
       MovePlayer();
       //LLamamos a la funcion ConstrainPlayerPosition()
       ConstrainPlayerPosition();
        
    }

    //Funcion MovePlayer()
    void MovePlayer(){
        //Variable para detectar si mueve las flechas horizontales
        float horizontalInput = Input.GetAxis("Horizontal");
        //Variable para detectar si mueve las flechas verticales
        float verticalInput = Input.GetAxis("Vertical");

        //Si se mueven las flechas verticales esta linea de codigo hara que se mueva en ese sentido el jugador
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        //Si se mueven las flechas horizontales esta linea de codigo hara que se mueva en ese sentido el jugador
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
    //Función ConstrainPlayerPosition
    void ConstrainPlayerPosition(){
        //Condicion para limitar en el eje z del lado de los negativos
        if(transform.position.z < -zBound){
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        //Condicion para limitar en el eje z del lado de los positivos 
        if(transform.position.z > zBound){
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }

    //Función de colision 
    private  void OnCollisionEnter(Collision other)
    {
        //Condición para mandar un mensaje al colisionar con un enemigo 
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Jugador colisiono con un enemigo");
        }

    }

    //Funcion de trigger 
    private  void OnTriggerEnter(Collider other)
    {
        //Condición al hacer contacto con un powerup destruira el objeto
        if(other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}
