using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rb.linearVelocity = Vector2.up * _velocity;
        }
    }

}

