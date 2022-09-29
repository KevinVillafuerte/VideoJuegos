using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelle Chimal Villafuerte
//Grupo: GDGS2102-e
//Fecha: 26/Septiembre/2022
//Carrera: Ing. Desarrollo De Software
//Materia: Creacion de Videojuegos

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
