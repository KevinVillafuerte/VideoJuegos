using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Autor: Kevin Michelel Chimal Villafuerte
//Fecha de Creacionn 17/Octubre/2022
//Grupo: GDGS2102-e
//Carrera: Ingenieria de Desarrollo de Software
//Materia: Creacionn de Video Juegos

public class DificultadBotones : MonoBehaviour
{
    private Button boton;//Se crea una variable para usar el objeto boton
    private GameManager gameManager;//Variable para usae wl Gamen Manager
    public int dificultad;//Variable para la dificultad

    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Metodo para la dificultad */
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked ");
        gameManager.StartGame(dificultad);
    }
}
