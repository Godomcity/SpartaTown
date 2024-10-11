using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpartaAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private SpartaController controller;

    private void Awake()
    {
        controller = GetComponent<SpartaController>();
    }

    void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 aimDirection)
    {
        RotateCharacter(aimDirection);
    }

    private void RotateCharacter(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
