using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryCamShake : MonoBehaviour
{
    public float shakeDuration = 0.2f; // Sars�nt� s�resi
    public float shakeIntensity = 0.05f; // Sars�nt� �iddeti

    public Slider slider; // Slider objesi

    private Vector3 originalPosition; // Orijinal kamera konumu
    private float shakeTimer; // Sars�nt� s�re sayac�

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
        // Slider'�n rotation de�i�kenlerini rastgele de�erlerle de�i�tirerek sallanma efekti olu�turuyoruz
        slider.transform.localEulerAngles = new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f));
    }
}
