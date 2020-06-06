using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author - Ricardo José Fellini
// 2D Flying 1.0

public class Director : MonoBehaviour
{
    [SerializeField]  
    private GameObject imagemGameOver;
    private Airplane airplane;
    private Ponctuation pontuaction;



    private void Start()
    {
        airplane = GameObject.FindObjectOfType<Airplane>();
        pontuaction = GameObject.FindObjectOfType<Ponctuation>();
    }


    public void EndGame()
    {

        Time.timeScale = 0f;
        imagemGameOver.SetActive(true);
    }
    
    public void RestartGame()
    {


        imagemGameOver.SetActive(false);
        Time.timeScale = 1f;
        airplane.RestartGame();
        DestroyObstacle();
        pontuaction.RestartGame();
    }

    // Destroy obstacles when it collides in a object definied in the scene

    private void DestroyObstacle()
    {

        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();
        foreach(Obstacle obstacle in obstacles)
        {

            obstacle.Destroy();
        }

    }
}
