using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovForFirstScene : MonoBehaviour
{
    public Transform target;    // The target object to follow
    public float smoothing = 5f;    // The speed of camera movement

    private Vector3 offset;    // The initial offset between the camera and the target

    void Start()
    {
        offset = transform.position - target.position;    // Calculate the initial offset between the camera and the target
    }

    void FixedUpdate()
    {
        if (target.position.x >= 9.1)
        {
            Vector3 targetCamPos = target.position + offset;    // Calculate the target position of the camera based on the offset
            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);    // Move the camera towards the target position using a Lerp function
        }
    }
}
