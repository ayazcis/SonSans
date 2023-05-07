using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tryspacebar : MonoBehaviour
{
    public float fillStartSpeed = 0.05f;
    public float fillAcceleration = 0.01f;
    public float decreaseSpeed = 0.1f;
    public float maxFill = 1f;
    public float resetTime = 3f;
    public GameObject forscenechange;

    private bool gectisinir = false;
    private Slider slider;
    private bool canFill = true;
    private bool canDecrease = true;
    private float currentFillSpeed;
    private float timeSinceDecrease = 0f;
    private float lastSliderValue;

    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0f;
        currentFillSpeed = fillStartSpeed;
    }

    private void Update()
    {
        if(slider.value == maxFill)
        {
            forscenechange.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && canFill && (!gectisinir))
        {
            slider.value += currentFillSpeed;
            if (slider.value >= 0.9f)
            {
                slider.value = maxFill;
                canFill = false;
                gectisinir = true;
            }
            else
            {
                currentFillSpeed += fillAcceleration;
            }
        }

        if (slider.value > 0f && canDecrease && (!gectisinir) )
        {
            slider.value -= decreaseSpeed * Time.deltaTime;
            timeSinceDecrease += Time.deltaTime;

            if (slider.value <= 0f)
            {
                slider.value = 0f;
                //canDecrease = false;
                canFill = true;
                currentFillSpeed = fillStartSpeed;
                timeSinceDecrease = 0f;
            }
            else if (slider.value > lastSliderValue && !canFill)
            {
                currentFillSpeed = fillStartSpeed;
            }

            lastSliderValue = slider.value;

            if (timeSinceDecrease > resetTime)
            {
                currentFillSpeed = fillStartSpeed;
                timeSinceDecrease = 0f;
            }
        }
        else if (slider.value >= 0.9f)
        {
            slider.value = maxFill;
            canFill = false;
            gectisinir = true;
        }
    }
}

