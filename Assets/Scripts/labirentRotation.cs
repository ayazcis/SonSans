using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labirentRotation : MonoBehaviour
{
    public float rotate = 5.0f;
    public float rotateRight = -5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
            transform.Rotate(0.0f, 0.0f, rotate * Time.deltaTime);
		}
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, 0.0f, rotateRight * Time.deltaTime);
        }
    }
}
