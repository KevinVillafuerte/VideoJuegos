using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Alumno: Kevin Michelle Chimal Villafuerte
Grupo: GDGS2102-e
Fecha de Creacion: 27/Octubre/2022
Carrera: Ing. Desarrollo de Software 
Materia: Desarrollo de Video Juegos
*/

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX scriptSpawnManagerX;//Variable para acceder al spawn manager

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");
        scriptSpawnManagerX = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
        speed = scriptSpawnManagerX.velocidadEnemigo;
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
