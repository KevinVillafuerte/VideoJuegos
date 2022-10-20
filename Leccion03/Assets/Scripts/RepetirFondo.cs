using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 14/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class RepetirFondo : MonoBehaviour
{
    private Vector3 starPos;//Declaramos una variable para pocision del Objeto
    private float repeatWidth;//Variable para restablecer la pocision
    // Start is called before the first frame update
    void Start()
    {
        starPos = transform.position;//Inicio de la nueva pocision del Fondo
        repeatWidth= GetComponent<BoxCollider>().size.x / 2;//Establecemos el tamaño del Collier
    }

    // Update is called once per frame
    void Update()
    {
        /*Condicion para la transicion del fondo*/
        if (transform.position.x < starPos.x - repeatWidth)
        {
            transform.position = starPos;
        }
    }
}
