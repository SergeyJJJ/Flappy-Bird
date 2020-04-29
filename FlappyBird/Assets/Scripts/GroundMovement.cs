using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    private float _repeatWidth;
    private Vector2 _startPosition;
    private BoxCollider2D _collider;
    
    private void Awake()
    {
        float _adjustRepeatWidth = 0.3f;

        _startPosition = transform.position;
        _collider = GetComponent<BoxCollider2D>();
        _repeatWidth = (_collider.size.x / 2) + _adjustRepeatWidth;
    }

    private void FixedUpdate()
    {
        Move();
        RepeatPosition();
    }

    private void Move()
    {
        transform.Translate(Vector2.left * _speed);
    }

    private void RepeatPosition()
    {
        Vector3 currnetPosition = transform.position;

        if (_startPosition.x - currnetPosition.x >= _repeatWidth)
        {
            transform.position = _startPosition;
        }
    }
}
