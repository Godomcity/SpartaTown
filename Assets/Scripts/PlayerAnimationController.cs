using System;
using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("isWalking");

    private readonly float magnituteThreshold = 0.5f;

    protected void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(IsWalking, vector.magnitude > magnituteThreshold);
    }
}