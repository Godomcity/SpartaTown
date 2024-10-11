using System;
using UnityEngine;

public class SpartaMovement : MonoBehaviour
{
    private SpartaController controller;
    private Rigidbody2D rigidbody;

    private Vector2 directionMovement = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<SpartaController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(directionMovement);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        rigidbody.velocity = direction;
    }

    private void Move(Vector2 vector)
    {
        directionMovement = vector;
    }
}
