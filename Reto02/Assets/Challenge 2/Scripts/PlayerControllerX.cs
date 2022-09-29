using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelle Chimal Villafuerte
//Grupo: GDGS2102-e
//Fecha: 26/Septiembre/2022
//Carrera: Ing. Desarrollo De Software
//Materia: Creacion de Videojuegos

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float tiempoEspera = 1;
    private float tiempoDisparoEspera = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoDisparoEspera)
        {
            tiempoDisparoEspera = Time.time + tiempoEspera;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
