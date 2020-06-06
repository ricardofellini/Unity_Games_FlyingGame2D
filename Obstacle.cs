using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Author - Ricardo José Fellini
// 2D Flying 1.0

public class Obstacle : MonoBehaviour
{


    // Declaration of variables

    [SerializeField]
    private float velocity  = 0.5f;
    [SerializeField]
    private float positionVariationY;
    private Vector3 positionAirplane;
    private Ponctuation punctuation;
    private bool scored;

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-positionVariationY, positionVariationY));
    }

    private void Start()
    {
        positionAirplane = GameObject.FindObjectOfType<Airplane>().transform.position;
        punctuation = GameObject.FindObjectOfType<Ponctuation>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocity * Time.deltaTime);


        // Add points when the position of object is less than obstacle just one time for obstacle

        if(!this.scored && this.transform.position.x < this.positionAirplane.x)
        {

            scored = true;
            punctuation.AddPoints();
        }

           

    }


    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy();
    }

    public void Destroy()
    {
        Destroy(gameObject);


    }
}
