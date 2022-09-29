using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creación 12/Septiembre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creación de Video Juegos

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Se crean variables para darle valor al carro para que avanze y gire
        float avanza = Input.GetAxis("Vertical");
        float girar = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime*velocidad*avanza);
        transform.Rotate(Vector3.up, Time.deltaTime *30*girar);
     
    }
}
