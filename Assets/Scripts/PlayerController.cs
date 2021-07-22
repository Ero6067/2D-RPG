using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    private float inputX;
    private float inputY;

    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    [Header("Player Resource Settings")]
    public int health = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        if (rb == null) { Debug.Log("NO RIGIDBODY2D FOUND ON PLAYER."); }
    }

    private void Start()
    {
    }

    private void Update()
    {
        rb.velocity = new Vector2(inputX * moveSpeed, inputY * moveSpeed);
        anim.SetFloat("moveX", rb.velocity.x);
        anim.SetFloat("moveY", rb.velocity.y);
        if (rb.velocity.x != 0 || rb.velocity.y != 0) anim.SetFloat("moving", 1f);
        else anim.SetFloat("moving", 0f);
    }

    public void Move(InputAction.CallbackContext context)
    {
        inputX = context.ReadValue<Vector2>().x;
        inputY = context.ReadValue<Vector2>().y;
    }
}