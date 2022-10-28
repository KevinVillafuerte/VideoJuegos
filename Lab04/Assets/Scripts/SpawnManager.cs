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

public class SpawnManager : MonoBehaviour
{
    //Variable con un array de objetos
    public GameObject[] enemies;
    //Variable con un objeto que se usara para el powerup
    public GameObject powerup;
    //Variable para el limite de spawn de los enemigos en el eje y
    private float zEnemySpawn = 12.0f;
    //Variable para el limite de spawn en el eje x
    private float xSpawnRange = 16.0f;
    //Variable para el limite de spawn del powerup en el eje z
    private float zPowerupRange = 5.0f;
    //Variable para el spawn en el eje y
    private float ySpawn = .75f;
    //Variable para el tiempo de spawn de los powerup
    private float powerupSpawnTime = 5.0f;
    //Variable para el tiempo de spawn de los enemigos
    private float enemySpwanTime=1.0f;
    //Variable para el tiempo de espera para cada repeticion de función
    private float startDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //Repetición de la función SpawnEnemy
        InvokeRepeating("SpawnEnemy", startDelay, enemySpwanTime);
        //Repetición de la función SpawnPowerup
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //Función para crear enemigos
    void SpawnEnemy(){
        //Variable para la creación de los objetos en el eje x de forma aleatoria 
        float randomx = Random.Range(-xSpawnRange, xSpawnRange);
        //Variable para la creación de enemigos al azar 
        int randomIndex = Random.Range(0, enemies.Length);
        //Variable tipo Vector3 para posición final del enemigo
        Vector3 spawnPos = new Vector3(randomx, ySpawn, zEnemySpawn);
        //Creación del enemigo 
        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }
    //Función para crear powerup
    void SpawnPowerup(){
        //Variable para la creación de los objetos en el eje x de forma aleatoria 
        float randomx = Random.Range(-xSpawnRange, xSpawnRange);
        //Variable para la creación de los objetos en el eje z de forma aleatoria 
        float randomz = Random.Range(-zPowerupRange, zPowerupRange);
        //Variable tipo Vector3 para posición final del powerup
        Vector3 spawnPos = new Vector3(randomx, ySpawn, randomz);
        //Creación del powerup
        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
