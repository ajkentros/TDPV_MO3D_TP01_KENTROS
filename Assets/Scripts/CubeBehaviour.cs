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
                transform.Rotate(RotationSpeed * Vector3.right * Time.deltaTime);
                break;
            case Axis.y:
                transform.Rotate(RotationSpeed * Vector3.up * Time.deltaTime);
                break;
            case Axis.z:
                transform.Rotate(RotationSpeed * Vector3.forward * Time.deltaTime);
                break;
        }
    }

}
