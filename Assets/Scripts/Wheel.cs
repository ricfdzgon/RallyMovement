using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private WheelCollider wCollider;
    private float steerAngle = 20;

    void Start()
    {
        wCollider = GetComponentInChildren<WheelCollider>();
    }

    public void Accelerate(float torque)
    {
        wCollider.motorTorque = torque;
    }

    public void Brake(float torque)
    {
        wCollider.brakeTorque = torque;
    }
}
