using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : MonoBehaviour
{
    public Wheel frontLeftWheel;
    public Wheel frontRightWheel;
    public Wheel RearLeftWheel;
    public Wheel ReartRightWheel;

    private Wheel[] wheels;

    public float motorTorque;
    public float brakeTorque;
    private float moveDirection;
    private bool brake;

    void Start()
    {
        wheels = new Wheel[4];
        wheels[0] = frontLeftWheel;
        wheels[1] = frontRightWheel;
        wheels[2] = RearLeftWheel;
        wheels[3] = ReartRightWheel;
    }

    void Update()
    {
        moveDirection = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            brake = true;
        }
        else
        {
            brake = false;
        }
    }

    void FixedUpdate()
    {
        if (brake)
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.Brake(brakeTorque);
            }
        }
        else
        {
            foreach (Wheel wheel in wheels)
            {
                wheel.Brake(0);
            }
            RearLeftWheel.Accelerate(moveDirection * motorTorque);
            ReartRightWheel.Accelerate(moveDirection * motorTorque);
        }
    }
}
