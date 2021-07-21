using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    private float inputX;
    private float inputY;

    private void Awake()
    {
    }

    private void Start()
    {
    }

    private void Update()
    {
        rb.velocity = new Vector2(inputX * moveSpeed, inputY * moveSpeed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        inputX = context.ReadValue<Vector2>().x;
        inputY = context.ReadValue<Vector2>().y;
    }
}