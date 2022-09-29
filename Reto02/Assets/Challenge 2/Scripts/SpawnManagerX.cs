using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelle Chimal Villafuerte
//Grupo: GDGS2102-e
//Fecha: 26/Septiembre/2022
//Carrera: Ing. Desarrollo De Software
//Materia: Creacion de Videojuegos

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int bola = Random.Range(0, 3);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[bola], spawnPos, ballPrefabs[bola].transform.rotation);

        startDelay = Random.Range(1, 5);

        Invoke("SpawnRandomBall", startDelay);
    }

}
