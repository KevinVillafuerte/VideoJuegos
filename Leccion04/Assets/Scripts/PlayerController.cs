using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Alumno: Kevin Michelle Chimal Villafuerte
Grupo: GDGS2102-e
Fecha de Creacion 24/Octubre/2022
Carrera: Ing. Desarrollo de Software
Materia: Desarrollo de Video Juegos
*/

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;//Variable para referencia al RigidBody
    public float speed = 5.0f;//Variable para asignar velocidad al jugador 
    private GameObject focalPoint;//Variable para hacer referencia al objeto focalPoint
    public bool hasPowerup = false;//Esta variable es para el poder
    private float powerupStrength = 15.0f;//Fuerza para el powerUp
    public GameObject powerupIndicator;//variable para indicar el powerUp

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();//Utilizamos la referencia para el RigidBody
        focalPoint = GameObject.Find("Focal Point");//Hacemos uso del Focal Point que es para enfocar cierto punto
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input .GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    /* Funcion para el PowerUp*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hola");
        //Ciclo para validar el powerUp
        if( other.CompareTag("Poweup"))
        {
            Debug.Log("Hola");
            hasPowerup = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            
        }
    }

    /*Metodo para el temporizador del PowerUp*/
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    /* Metodo para la colision del Jugador con el enemigo*/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            //Se usa lo siguiente para poder aplicar fuerza
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            //Se comprueba que al hacer contacto con el enemigo este el powerUp activado  
            Debug.Log(" Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerup);
            //Se agrega fuerza de impulso al momento de tomar el powerUp
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
}
