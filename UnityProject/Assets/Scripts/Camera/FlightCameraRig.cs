using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightCameraRig : MonoBehaviour
{

    public float speed = 10;


    private float pitch = 0;
    private float yaw = 0;


    public float mouseSensitivityX = 100;
    public float mouseSensitivityY = 100;



    private void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }




    // Update is called once per frame
    void Update()
    {

        // Update Position

        float v = Input.GetAxis("Vertical");//forward/ backward
        float h = Input.GetAxis("Horizontal");//left / right (strafe)


        // transform.position += transform.forward * v * Time.deltaTime;
        // transform.position += transform.forward * h * Time.deltaTime; 


        Vector3 dir = transform.forward * v + transform.right * h;
        if (dir.magnitude > 1) dir.Normalize();

        transform.position += dir * Time.deltaTime * speed;


        //Update Rotation

        float mx = Input.GetAxis("Mouse X"); //yaw (Y - Axis)
        float my = Input.GetAxis("Mouse Y"); //pitch (X - Axis)

        yaw += mx * mouseSensitivityX;
        pitch -= my * mouseSensitivityY;

        pitch = Mathf.Clamp(pitch, -89, 89);


        transform.rotation = Quaternion.Euler(pitch, yaw, 0);


    }
}
