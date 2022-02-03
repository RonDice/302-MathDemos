using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GUIDemo : MonoBehaviour
{

    public TMP_Text textPlayerHealth;
    public Slider slider;
    public Dropdown dropdown;
    public Text TextBox;
    public static bool GamePaused = false;

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
        if (GamePaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
        
    }
    public void SliderUpdate(float value)
    {
        Time.timeScale = value;
    }

    void Resume()
    {
        Time.timeScale = 1;
        GamePaused = false;
    }

    void Pause()
    {
        Time.timeScale = 0;
        GamePaused = true;
    }

}
