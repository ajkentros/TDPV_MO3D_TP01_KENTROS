using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public enum Axis { x, y, z };


    [SerializeField]
    [Tooltip("Eje de rotación")]
    private Axis rotationAxis;
    public Axis RotationAxis { get => rotationAxis; set => rotationAxis = value; }
  

    [SerializeField]
    [Range(-45f, 45f)]
    private float rotationSpeed;
    public float RotationSpeed { get => rotationSpeed; set => rotationSpeed = value; }
   

    private float rotationSpeedInitial;
    public float RotationSpeedInitial { get => rotationSpeedInitial; }


    void Start()
    {
        rotationSpeedInitial = rotationSpeed;
    }

    void FixedUpdate()
    {
        Rotation();
    }

    private void Rotation()
    {
        switch (rotationAxis)
        {
            case Axis.x:
                transform.Rotate(RotationSpeed * Time.deltaTime * Vector3.right);
                break;
            case Axis.y:
                transform.Rotate(RotationSpeed * Time.deltaTime * Vector3.up);
                break;
            case Axis.z:
                transform.Rotate(RotationSpeed * Time.deltaTime * Vector3.forward);
                break;
        }
    }

}
