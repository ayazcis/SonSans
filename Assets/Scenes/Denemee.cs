using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Denemee : MonoBehaviour
{
    private Vector3 startPosition;
    private bool isDragging = false;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;

        // Nesneyi b�rakt���m�zda, kareye yerle�tirme i�lemi ger�ekle�tirilir
        Vector2 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector2.zero);

        // Kesi�en nesne varsa
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("EmptySquare"))
            {
                // Nesne o kareye yerle�tirilir
                transform.position = hit.collider.transform.position;
                // Nesnenin parent'�, o kare yap�l�r
                transform.parent = hit.collider.transform;
                // Kare art�k dolu oldu�undan, tag'i "EmptySquare" yerine "FilledSquare" olarak g�ncellenir
                hit.collider.tag = "FilledSquare";
            }
            else
            {
                // Nesne bir kareye yerle�tirilemezse, ba�lang�� pozisyonuna geri g�nderilir
                transform.position = startPosition;
            }
        }
        else
        {
            // Nesne bir kareye yerle�tirilemezse, ba�lang�� pozisyonuna geri g�nderilir
            transform.position = startPosition;
        }
    }

    private void Update()
    {
        if (isDragging)
        {
            // Nesne fare pozisyonuna takip eder
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }

    private void Start()
    {
        // Nesnenin ba�lang�� pozisyonu kaydedilir
        startPosition = transform.position;
    }
}
