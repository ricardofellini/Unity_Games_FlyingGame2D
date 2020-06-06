
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Author - Ricardo José Fellini
// 2D Flying 1.0

public class Airplane : MonoBehaviour
{

    // Declaration of variables

    private Rigidbody2D physics;
    [SerializeField]
    private float force;
    private Director director;
    private Vector3 initialPosition;



    // Checks the airplane's initial position

    private void Awake()
    {
        initialPosition = transform.position;
        physics = GetComponent<Rigidbody2D>();
        
        
    }

    private void Start()
    {
        director = GameObject.FindObjectOfType<Director>();
    }


    // Move airplane when click Fire1

    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Impulse();
        }

    }

    // Restarts the game when it collides

    public void RestartGame()
    {

        transform.position = initialPosition;
        physics.simulated = true;
    }

    // Force of impulse the airplane

    private void Impulse()
    {
        physics.velocity = Vector2.zero;
        physics.AddForce(Vector2.up * force, ForceMode2D.Impulse);

    }
    private void OnCollisionEnter2D(Collision2D colisao)
    {

        // Stop the physics and end the game

        physics.simulated = false;
        director.EndGame();
    }
}
