using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 40f;

    Vector2 movement;

    public Joystick joystick;

    Rigidbody2D rb;

    public RectTransform handlePos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * runSpeed * Time.fixedDeltaTime);

        Vector2 handlePosition = new Vector2(handlePos.anchoredPosition.x, handlePos.anchoredPosition.y);

        Vector2 lookDir = handlePosition;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;
    }
}
