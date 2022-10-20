using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 17/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;//Creamos nuestra matriz
    private float spawnRate = 1.0f;// Variable para el tiempo de espera para salir un objeto
    private int puntuacion;//Variable para almacenar la puntuacion
    public TextMeshProUGUI scoreText; // Variable para la puntuacion
    public TextMeshProUGUI gameOverText;//Variable para mostar el texto de Game Over
    public bool isGameActive;//Variable para iniciar el juego
    public Button reinicioBoton;//Variable para el boton de reinicio
    public GameObject titleScreen;//Variable para ña pantalla de juego inicial

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Cramos un metodo  */
    IEnumerator SpawnTarget()
    {
        /* Usamos una condicion para controlar el tiempo que transcurre para generar objetos */
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);

        }
    }

    /* Metodo para que aumente la puntuacion */
    public void UpdateScore(int scoreToAdd)
    {
        puntuacion += scoreToAdd;
        scoreText.text = "Puntuación: " + puntuacion;
    }

    /* Metodo para finalizar el juego */
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        reinicioBoton.gameObject.SetActive(true);
    }
    /* Funcion para el boton de reinicio */
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /* Metodo para iniciar el juego */
    public void StartGame( int dificultad)
    {
        isGameActive = true;
        spawnRate /= dificultad;
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        
    }
}
