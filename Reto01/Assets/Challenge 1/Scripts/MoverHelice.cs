using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHelice : MonoBehaviour
{
    public float velocidadGiro = 1000.0f; //Se le asigna un valor para dar la velocidad a la helice
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadGiro); // Se aplica la velocidad
    }
}

