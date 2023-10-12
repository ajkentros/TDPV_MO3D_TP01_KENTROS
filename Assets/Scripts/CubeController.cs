using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeBehaviour cubeBehaviour;


    // Start is called before the first frame update
    void Start()
    {
        cubeBehaviour = GetComponent<CubeBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        // Control de rotación
        if (Input.GetKeyDown(KeyCode.X))
        {
            cubeBehaviour.RotationAxis = CubeBehaviour.Axis.x;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            cubeBehaviour.RotationAxis = CubeBehaviour.Axis.y;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Rotate();
            cubeBehaviour.RotationAxis = CubeBehaviour.Axis.z;
        }
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rotate();
            cubeBehaviour.RotationSpeed = -cubeBehaviour.RotationSpeedInitial;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rotate();
            cubeBehaviour.RotationSpeed = cubeBehaviour.RotationSpeedInitial;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubeBehaviour.RotationSpeed = 0f;
        }
    }

    private void Rotate()
    {
        if(cubeBehaviour.RotationSpeed == 0f)
        {
            cubeBehaviour.RotationSpeed = cubeBehaviour.RotationSpeedInitial;
        }
    }
}
