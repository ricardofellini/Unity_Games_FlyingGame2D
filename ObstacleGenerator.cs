using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Author - Ricardo José Fellini
    // 2D Flying 1.0

    [SerializeField]
    private float timeGenerate;
    [SerializeField]
    private GameObject manualInstructions;
    private float chronometer;


    private void Awake()
    {
        chronometer = timeGenerate;
    }


    void Update()
    {
        chronometer -= Time.deltaTime;
        if(chronometer < 0)
        {

            GameObject.Instantiate(manualInstructions, transform.position, Quaternion.identity);
            chronometer = timeGenerate;

        }
    }
}
