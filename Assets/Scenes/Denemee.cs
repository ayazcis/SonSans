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

        // Nesneyi býraktýðýmýzda, kareye yerleþtirme iþlemi gerçekleþtirilir
        Vector2 rayPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector2.zero);

        // Kesiþen nesne varsa
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("EmptySquare"))
            {
                // Nesne o kareye yerleþtirilir
                transform.position = hit.collider.transform.position;
                // Nesnenin parent'ý, o kare yapýlýr
                transform.parent = hit.collider.transform;
                // Kare artýk dolu olduðundan, tag'i "EmptySquare" yerine "FilledSquare" olarak güncellenir
                hit.collider.tag = "FilledSquare";
            }
            else
            {
                // Nesne bir kareye yerleþtirilemezse, baþlangýç pozisyonuna geri gönderilir
                transform.position = startPosition;
            }
        }
        else
        {
            // Nesne bir kareye yerleþtirilemezse, baþlangýç pozisyonuna geri gönderilir
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
        // Nesnenin baþlangýç pozisyonu kaydedilir
        startPosition = transform.position;
    }
}
