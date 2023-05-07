using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splashing : MonoBehaviour
{
    public float xForce;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(xForce, 0f), ForceMode2D.Impulse);
        }
    }
}
















