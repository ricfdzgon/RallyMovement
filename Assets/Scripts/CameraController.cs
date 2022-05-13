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
        if (Input.GetKey(KeyCode.J))
        {
            Vector3 eulerangles = transform.eulerAngles;
            eulerangles.y += rotationSpeed * Time.deltaTime;
            transform.eulerAngles = eulerangles;
        }
        if (Input.GetKey(KeyCode.L))
        {
            Vector3 eulerangles = transform.eulerAngles;
            eulerangles.y -= rotationSpeed * Time.deltaTime;
            transform.eulerAngles = eulerangles;
        }
        if (Input.GetKey(KeyCode.I))
        {
            Vector3 eulerangles = camera.eulerAngles;
            eulerangles.x -= rotationSpeed * Time.deltaTime;
            camera.eulerAngles = eulerangles;
        }
        if (Input.GetKey(KeyCode.K))
        {
            Vector3 eulerangles = camera.eulerAngles;
            eulerangles.x += rotationSpeed * Time.deltaTime;
            camera.eulerAngles = eulerangles;
        }
    }
}
