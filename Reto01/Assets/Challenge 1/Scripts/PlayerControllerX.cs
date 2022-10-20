using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Autor: Kevin Michelle Chimal Villafuerte
Grupo: Gdgs2102-E
Carrera: Ing. Desarrollo de Software
Fecha 19/Septiembre/2022
*/

public class PlayerControllerX : MonoBehaviour
{
    public float speed; // La velocidad del Avion
    public float rotationSpeed; // La rotacion 
    public float verticalInput; // La velocidad para subir y bajar el avión

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
