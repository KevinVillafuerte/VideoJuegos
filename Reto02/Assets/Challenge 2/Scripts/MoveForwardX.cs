using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelle Chimal Villafuerte
//Grupo: GDGS2102-e
//Fecha: 26/Septiembre/2022
//Carrera: Ing. Desarrollo De Software
//Materia: Creacion de Videojuegos

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
