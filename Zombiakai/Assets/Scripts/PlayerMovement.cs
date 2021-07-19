using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    public Joystick joystick;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeed;
        verticalMove = joystick.Vertical * runSpeed;

        rb.velocity = new Vector2(horizontalMove, verticalMove);
    }
}
