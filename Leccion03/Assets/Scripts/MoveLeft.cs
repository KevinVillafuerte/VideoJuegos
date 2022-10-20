using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 14/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class MoveLeft : MonoBehaviour
{
    private float velocidad = 27;//Se crea una variable para la velocidad  y es privada
    private TomasController tomasControllerScript;//Declaramos esta variable para hacer referencia al script del Jugador
    private float leftBound = -15;//Creamos una variable para asigar limite

    // Start is called before the first frame update
    void Start()
    {
        /* Establecemos el uso del Scrip al que estamos haciendo refrencia o queremos hacer */
        tomasControllerScript = GameObject.Find("Tomas").GetComponent<TomasController>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Poner una condicion para que el momento de que el jugador colicione haga el GameOver */
        if(tomasControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * velocidad);
        }

        /* Creamos una condicion donde obtendremos la picision del objeto para despues proceder a destruir */
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
