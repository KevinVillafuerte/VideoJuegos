using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelle Chimal Villafuerte
//Grupo: GDGS2102-e
//Fecha: 26/Septiembre/2022
//Carrera: Ing. Desarrollo De Software
//Materia: Creacion de Videojuegos

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
