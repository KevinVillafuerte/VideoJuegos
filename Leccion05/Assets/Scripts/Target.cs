using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 17/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;//Variable para el Rigi Body
    private GameManager gameManager;//Variable para usar elementos del GameManager
    private float minVelocidad = 12;//Variable para la velocidad minima
    private float maxVelocidad = 16;//Variable para la velocidad maxima
    private float maxRotacion = 10;//Variable para la rotacion
    private float xRango = 4;//Variable para el valos de X
    private float ySpawnPos = -3;//Variable para la pocion de Y
    public int pointValue;//
    public ParticleSystem explosionParticle;
    
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        /* Usamos el gameManager para poder usarlo como objeto */
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        //Agregamos para que el objeto tenga fuerza y caiga con un impulso hacia arriba
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        //Hacemos uso del Torque para aplicar fuerza a los objetos para que roten
        targetRb.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(),ForceMode.Impulse);
        //Creamos un lugar o pocision aleatoria donde se generan los objetos
        transform.position = RandomSpawnPos();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Metodo para el mouse*/
    private void OnMouseDown()
    {
        if(gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpdateScore(pointValue);
        }
    }

    /**/
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if(!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }

    /* Metodo para aplicar fuerza aleatoria */
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minVelocidad, maxVelocidad);
    }

    /* Metodo para la rotacion de objetos */
    float RandomTorque()
    {
        return Random.Range(-maxRotacion, maxRotacion);
    }

    /* Metodo para el espam aleatorio de objetos */
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRango, xRango), ySpawnPos);
    }

}
