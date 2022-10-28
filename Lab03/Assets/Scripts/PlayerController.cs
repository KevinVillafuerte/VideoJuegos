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

public class PlayerController : MonoBehaviour
{
    private float speed = 18.0f;
    private Rigidbody playerRb;
    private float zBound = 6;
    // Start is called before the first frame update
    void Start()
    {
          playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
       ConstrainPlayerPosition();
        
    }

    void MovePlayer(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void ConstrainPlayerPosition(){
        if(transform.position.z < -zBound){
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if(transform.position.z > zBound){
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}