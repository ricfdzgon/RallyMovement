using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform camera;
    private float rotationSpeed = 90;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 eulerangles = transform.localEulerAngles;
        if (Input.GetKey(KeyCode.J))
        {
            eulerangles.y += rotationSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.L))
        {
            eulerangles.y -= rotationSpeed * Time.deltaTime;
        }
        transform.localEulerAngles = eulerangles;

        eulerangles = camera.transform.localEulerAngles;

        if (Input.GetKey(KeyCode.I))
        {
            eulerangles.x -= rotationSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.K))
        {
            eulerangles.x += rotationSpeed * Time.deltaTime;
        }
        camera.transform.localEulerAngles = eulerangles
    }
}
