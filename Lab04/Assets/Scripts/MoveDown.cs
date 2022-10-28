using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Alumno: Kevin Michelle Chimal Villafuerte
Grupo: GDGS2102-e
Fecha Creacion: 27/Octubre/2022
Carrera: ING. Desarrollo de Software
Materia: Desarollo de Video Juegos
*/

public class MoveDown : MonoBehaviour
{
    //Variable publica para la velocidad 
    public float speed = 5.0f;
    //Variable para establecer limite de objetos y destruirlos
    private float zDestroy= -10.0f;
    //Variable para usar rigidbody
    private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        //Llamamos al componente Rigidbody
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Esta linea hará que los objetos se muevan en una dirección
        objectRb.AddForce(Vector3.forward*-speed);
        //Condicion para destruir objetos fuera del limite 
        if(transform.position.z < zDestroy){
            Destroy(gameObject);
        }
    }
}
