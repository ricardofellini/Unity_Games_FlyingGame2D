using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author - Ricardo José Fellini
// 2D Flying 1.0

public class Ponctuation : MonoBehaviour
{

    // Declaration of variables

    [SerializeField]
    private Text textPonctuation;
    private int points;
    public AudioSource audioPonctuation;


    private void Awake()
    {
        audioPonctuation = GetComponent<AudioSource>();
        
    }

    // Add points in a text and convert to a string

    public void AddPoints()
    {

        points += 1;
        textPonctuation.text = points.ToString();
        audioPonctuation.Play();

    }

    public void RestartGame()
    {

        points = 0;
        textPonctuation.text = points.ToString();
    }
}
