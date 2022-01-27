using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GUIDemo : MonoBehaviour
{

    public TMP_Text textPlayerHealth;

    public Slider slider;

    void Start()
    {
        if(slider) slider.value = Time.timeScale;
    }

    // Update is called once per frame
    void Update()
    {
        textPlayerHealth.text = "No Hope";
    }

    public void ButtonClicked()
    {
        print("Button Clicked");
    }
    public void SliderUpdate(float value)
    {
        Time.timeScale = value;
    }

}
