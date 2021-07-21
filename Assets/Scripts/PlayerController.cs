using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private float inputX;
    private float inputY;

    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    [Header("Health Settings")]
    public int health = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb == null) { Debug.Log("NO RIGIDBODY2D FOUND ON PLAYER."); }
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