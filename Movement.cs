using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private float _currentSpeed;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();   
    }

    private void Update()
    {
        _currentSpeed = 0;

        if (Input.GetKey(KeyCode.D))
        {
            Move(_speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Move(_speed * -1, true);
        }

        _animator.SetFloat("Speed", _currentSpeed);
    }

    private void Move(float currentSpeed = 0, bool isFlipX = false)
    {
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
        _spriteRenderer.flipX = isFlipX;
        _currentSpeed = _speed;
    }
}
