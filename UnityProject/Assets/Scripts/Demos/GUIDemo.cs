using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GUIDemo : MonoBehaviour
{

    public TMP_Text textPlayerHealth;
    public Slider slider;
    public Dropdown mydropdown;
    public Text TextBox;
    public GameObject FlightCam;
    public GameObject OrbitalCam;
    public GameObject LookAtCam;

    void Start()
    {
        if(slider) slider.value = Time.timeScale;
    }

    // Update is called once per frame
    void Update()
    {
        textPlayerHealth.text = "Star Wars: No Hope";
    }

    public void ButtonClicked()
    {
        print("Button Clicked");
    }
    public void SliderUpdate(float value)
    {
        Time.timeScale = value;
    }
    
    public void HandleInputData (int val)
    {
        if (val == 0)
        {
            FlightCam.SetActive(true);
            LookAtCam.SetActive(false);
            OrbitalCam.SetActive(false);
        }
        if (val == 1)
        {
            LookAtCam.SetActive(true);
            FlightCam.SetActive(false);
            OrbitalCam.SetActive(false);
        }
        if (val == 2)
        {
            OrbitalCam.SetActive(true);
            FlightCam.SetActive(false);
            LookAtCam.SetActive(false);
        }
    }

}
