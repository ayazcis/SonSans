using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HorizontalMovement : MonoBehaviour
{
    public float thresholdX = 20f;
    public GameObject gameobject;
    public float moveSpeed = 5f;
    public float smoothTime = 0.3f;

    private bool activated = false;
    private float currentSpeed;
    private float targetSpeed;
    private float moveInput;

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        targetSpeed = moveInput * moveSpeed;
        currentSpeed = Mathf.Lerp(currentSpeed, targetSpeed, smoothTime);

        transform.position += new Vector3(currentSpeed * Time.deltaTime, 0, 0);
        if((transform.position.x > thresholdX) && (activated == false))
        {
            gameobject.SetActive(!gameobject.activeSelf);
            activated = true;
        }
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false; // face right
            animator.SetBool("isRunning", true);
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true; // face left
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
