using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryCamShake : MonoBehaviour
{
    public float shakeDuration = 0.2f; // Sarsýntý süresi
    public float shakeIntensity = 0.05f; // Sarsýntý þiddeti

    public Slider slider; // Slider objesi

    private Vector3 originalPosition; // Orijinal kamera konumu
    private float shakeTimer; // Sarsýntý süre sayacý

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartShake();
            ShakeSlider();
        }

        if (shakeTimer > 0f)
        {
            transform.position = originalPosition + Random.insideUnitSphere * shakeIntensity;
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            transform.position = originalPosition;
        }
    }

    private void StartShake()
    {
        shakeTimer = shakeDuration;
    }

    private void ShakeSlider()
    {
        // Slider'ýn rotation deðiþkenlerini rastgele deðerlerle deðiþtirerek sallanma efekti oluþturuyoruz
        slider.transform.localEulerAngles = new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f));
    }
}
