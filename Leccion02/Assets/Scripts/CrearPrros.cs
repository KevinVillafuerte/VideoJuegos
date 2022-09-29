using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kevin Michelel Chimal Villafuerte
//Fecha de Creación 23/Septiembre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creación de Video Juegos

public class CrearPrros : MonoBehaviour
{
    //Creacion de instancias
    public GameObject[] perros;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreatePerro", 2, 1.5F); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.P))
        {
            
        }
        
    }
    void CreatePerro()
    {
        // Se crea una variable para la aparicion random de los animales y se da la ubicacion para que aparezcan
        int aleatorio = Random.Range(0,3);
        int x = Random.Range(0, 0);
        Instantiate(perros[aleatorio],new Vector3(11,1,20), perros[aleatorio].transform.rotation);
    }
}
