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

public class Enemigo : MonoBehaviour
{
    public float speed = 3.0f;//Variable para la velocidad del enemigo
    private Rigidbody enemyRb;//Variable para usar el Rigid Body del enemigo
    private GameObject player;//Variable para un objeto que llamamos jugador

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();//Se usa el rigidBody para la fisica del objeto
        player = GameObject.Find("Player");//Se hace referencia al objeto jugador
    }

    // Update is called once per frame
    void Update()
    {
        //Creamos una variable para optimizar codigo
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        //Aplicamos la fuerza al enemigo
        enemyRb.AddForce(lookDirection * speed);

        //Condicion para que los enemigos se destruyan de la escena
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
