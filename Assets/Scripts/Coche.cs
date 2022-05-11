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
        moveDirection = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            brake = true;
        }
        else
        {
            brake = false;
        }
    }
}
