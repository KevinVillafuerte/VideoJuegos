using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kevin Michelel Chimal Villafuerte
//Fecha de Creación 23/Septiembre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creación de Video Juegos

public class MovePrros : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Condicion para que los animales que se generen se destruyan
        if (transform.position.z < -22)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward*Time.deltaTime*10);
    }
}
