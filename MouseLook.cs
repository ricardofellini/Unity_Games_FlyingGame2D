using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public enum RotationAxes
    {


        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXandY;
    public float sensitivyHor = 9.0f;


 
    void Update()
    {


        if (axes == RotationAxes.MouseX)
        {

            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivyHor, 0);


            // horizontal rotations here

        }
        else if(axes == RotationAxes.MouseY)
        {

            // vertical rotations here

        }
        else
        {
            // both horizontal and vertical here
        }
    }
}
