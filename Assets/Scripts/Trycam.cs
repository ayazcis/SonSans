using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trycam : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 offset = new Vector3(0, 2, -10);
    public float smoothTime = 0.1f;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        // Calculate the target position of the camera
        Vector3 targetPosition = targetTransform.position + offset;

        // Smoothly move the camera towards the target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
