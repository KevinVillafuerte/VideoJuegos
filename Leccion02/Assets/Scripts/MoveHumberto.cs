using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kevin Michelel Chimal Villafuerte
//Fecha de Creación 23/Septiembre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creación de Video Juegos

public class MoveHumberto : MonoBehaviour
{   // Se definene las variables como la velocidad y el maximo
    public float vel = 10.0F;
    public float maximo = 20;
    public GameObject hueso; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Se crean dos condiciones para que el personje no salga del mapa y tenga limite 
        if(transform.position.x > maximo)
        {
            transform.position = new Vector3(maximo, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -maximo)
        {
            transform.position = new Vector3(-maximo, transform.position.y, transform.position.z);
        }

        // Condicion para que al precionar una tecla se lanze el objeto
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(hueso, transform.position, hueso.transform.rotation);
        }

        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
        
    }
}
