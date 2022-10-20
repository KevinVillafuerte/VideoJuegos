using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Autor: Kevin Michelle Chimal Villafuerte
Grupo: Gdgs2102-E
Carrera: Ing. Desarrollo de Software
Fecha 19/Septiembre/2022
*/

public class MoverHelice : MonoBehaviour
{
    public float velocidadGiro = 1000.0f; //Se le asigna un valor para dar la velocidad a la helice
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadGiro); // Se aplica la velocidad
    }
}

