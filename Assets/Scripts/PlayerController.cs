using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private Animator anim;

    private float inputX;
    private float inputY;
    public static PlayerController instance;

    public string areaTransitionName;

    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

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
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        rb.velocity = new Vector2(inputX * moveSpeed, inputY * moveSpeed);
        anim.SetFloat("moveX", inputX);
        anim.SetFloat("moveY", inputY);
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            anim.SetFloat("moving", 1f);
            anim.SetFloat("lastMoveX", inputX);
            anim.SetFloat("lastMoveY", inputY);
        }
        else anim.SetFloat("moving", 0f);
    }

    public void Move(InputAction.CallbackContext context)
    {
        inputX = context.ReadValue<Vector2>().x;
        inputY = context.ReadValue<Vector2>().y;
    }
}