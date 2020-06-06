using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{

    // Declaration of variables

    [SerializeField]     
    private float velocity;
    private Vector3 initialPosition;
    private float realSizeImage;


    // Move the images in background

    private void Awake()
    {
        initialPosition = transform.position;
        float sizeImage = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        realSizeImage = sizeImage * escala;
    }


    void Update()
    {
        float deslocamento = Mathf.Repeat(velocity * Time.time, realSizeImage);
        transform.position = initialPosition + Vector3.left * deslocamento;
            
    }
}
