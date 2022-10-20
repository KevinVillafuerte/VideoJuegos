using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 14/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class SpamObstaculo : MonoBehaviour
{
    public GameObject obstaclePrefab;//Declaramos la variable para los objetos que se spamearan
    private Vector3 spawnPos = new Vector3(25, 0, 0);//Aqui decaramos donde queremos que se creen los objetos para el spam
    private float startDelay = 2;//Esta variable es para el tiempo de inicio
    private float repeatRate = 2;//Esta otra variable es para la repeticion
    private TomasController tomasControllerScript;//Variable para ligar a otro Script

    // Start is called before the first frame update
    void Start()
    {
        /*Se reutilza el metodo que se genero en la parte inferior llamado SpawnObstacle*/
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        /*Se hace uso de los objetos que estan en el script el cual se ligo*/
        tomasControllerScript = GameObject.Find("Tomas").GetComponent<TomasController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Se crea un metodo personalizado para la generacion de obstaculos*/
    void SpawnObstacle()
    {
        /**/
        if(tomasControllerScript.gameOver == false)
        {
            /* Con lo siguiente se nos permite crear los clones del objeto u obstaculo del Prefabs */
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
