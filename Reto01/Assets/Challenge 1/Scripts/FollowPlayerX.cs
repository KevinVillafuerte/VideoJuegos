using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Autor: Kevin Michelle Chimal Villafuerte
Grupo: Gdgs2102-E
Carrera: Ing. Desarrollo de Software
Fecha 19/Septiembre/2022
*/

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20,2,0);//Se le asigna la poosicion a la camara

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset; 
    }
}
