using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public GameObject FlightCam;
    public GameObject OrbitalCam;
    public GameObject LookAtCam;
    public int CamMode;

    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            if(CamMode == 1)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(CamChange());
        }
       
    }

    IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);

        if (CamMode == 0)
        {
            FlightCam.SetActive(true);
            OrbitalCam.SetActive(false);
            LookAtCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FlightCam.SetActive(false);
            OrbitalCam.SetActive(true);
            LookAtCam.SetActive(false);
        }
        if (CamMode == 2)
        {
            FlightCam.SetActive(false);
            OrbitalCam.SetActive(false);
            LookAtCam.SetActive(true);
        }
    }
}
