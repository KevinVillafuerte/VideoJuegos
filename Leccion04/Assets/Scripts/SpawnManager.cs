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

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;//Variable para hacer referencia al prefabs de enemigo
    public GameObject powerupPrefab;//Para usar el objeto powerUp de Prefabs
    private float spawnRange = 9.0f;//Variable para el rango de aparacion del enemigo
    public int enemyCount;//Variable para contar los enemigos que hay
    public int waveNumber = 1;//Para el contardor de enemigos
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemigo>().Length;
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }
    
    //Metodo para generar enemigos
    void SpawnEnemyWave( int enemiesToSpawn)
    {
        /*Ciclo para generar enemigos*/
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    /* Metodo para generar enemigos */
    private Vector3 GenerateSpawnPosition()
    {
        //Asignamos pocision para el punto de X
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        //Asignamos pocision para el punto de Z
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        //Ponemos para que se genere un nuevo enemigo en las pocisiones asignadas aleatoreamente
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
