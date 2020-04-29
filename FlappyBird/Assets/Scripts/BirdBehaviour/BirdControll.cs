using UnityEngine;
using UnityEngine.InputSystem;

public class BirdControll : MonoBehaviour
{
    private PlayerInputSystem _inputActions;
    private Rigidbody2D _playerRigidbody;
    [SerializeField] private float _jumpForce = 10;

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _inputActions = new PlayerInputSystem();
        _inputActions.BirdControll.KeyboardJump.performed += ctx => Jump();
    }

    private void Jump()
    {
        _playerRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void OnEnable()
    {
        _inputActions.BirdControll.Enable();    
    }

    private void OnDisable()
    {
        _inputActions.BirdControll.Disable();    
    }
}
