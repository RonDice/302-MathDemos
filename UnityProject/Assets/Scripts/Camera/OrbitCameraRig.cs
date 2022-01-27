using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCameraRig : MonoBehaviour
{



    public Transform thingToLookAt;


    private float pitch = 0;
    private float yaw = 0;
    private float disToTarget = 10;

    public float mouseSensitivityX = 100;
    public float mouseSensitivityY = 100;
    public float scrollSensitivity = 100;


    private Camera cam;



    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //Rotation
       float mx = Input.GetAxis("Mouse X");
       float my = Input.GetAxis("Mouse Y");

        yaw += mx * mouseSensitivityX;
        pitch -= my * mouseSensitivityY;

        pitch = Mathf.Clamp(pitch, -89, 89);


        transform.rotation = Quaternion.Euler(pitch, yaw, 0);

        //dolly (zoom)

        Vector2 ScrollAmt = Input.mouseScrollDelta;
        disToTarget += ScrollAmt.y * scrollSensitivity;
        disToTarget = Mathf.Clamp(disToTarget, 5, 50);

        float z = AnimMath.Ease(cam.transform.localPosition.z, -disToTarget, .01f);

        cam.transform.localPosition = new Vector3(0, 0, z);


        //Position
        if (thingToLookAt == null) return;


        //snap to target
        //transform.position = thingToLookAt.position;

        //ease to target
        transform.position = AnimMath.Ease(transform.position, thingToLookAt.position, .001f);



    }
}
