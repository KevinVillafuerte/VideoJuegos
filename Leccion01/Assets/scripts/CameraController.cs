using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creación 12/Septiembre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creación de Video Juegos

public class CameraController : MonoBehaviour
{
    public GameObject carro;
    // Start is called before the first frame update
    // Solo se le da la pocision a la camara
    private Vector3 pos = new Vector3(5,10,-10);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = carro.transform.position + pos;
    }
}
