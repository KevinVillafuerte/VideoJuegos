using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Alumno: Kevin Michelle Chimal Villafuerte
Grupo: GDGS2102-e
Fecha de Creacion 24/Octubre/2022
Carrera: Ing. Desarrollo de Software
Materia: Desarrollo de Video Juegos
*/

public class RotacionCamara : MonoBehaviour
{
    public float rotationSpeed; //Variable para asignar la velocidad de rotacion a la camara

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
