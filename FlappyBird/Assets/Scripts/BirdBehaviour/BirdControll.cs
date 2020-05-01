using UnityEngine;
//using UnityEngine.InputSystem;

public class BirdControll : MonoBehaviour
{
    [SerializeField] private AudioHandler _audioHandler;
    [SerializeField] private GameStateController _gameStateController;
    private PlayerInputSystem _inputActions;
    private Rigidbody2D _playerRigidbody;

    [SerializeField] private float _jumpForce = 10f;
    private float _upperBoundary = 7.39f;
    private float _jumpSpeedLimit = 5f;

    private bool _isGameLaunched = false;

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _inputActions = new PlayerInputSystem();
        _inputActions.BirdControll.KeyboardJump.performed += ctx => Jump();
    }

    private void Update()
    {
        PreventBirdOutOfBoundaries();
        SpeedLimit();
    }

    private void PreventBirdOutOfBoundaries()
    {
        if (transform.position.y > _upperBoundary)
        {
            transform.position = new Vector2(transform.position.x, _upperBoundary);
        }
    }
    
    private void SpeedLimit()
    {
        if (_playerRigidbody.velocity.y > _jumpSpeedLimit)
        {
            _playerRigidbody.velocity = new Vector2(0, _jumpSpeedLimit);
        }
    }

    private void Jump()
    {
        RunMainGame();
        _playerRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        _audioHandler.PlayWing();
    }

    private void RunMainGame()
    {
        if (!_isGameLaunched)
        {
            _isGameLaunched = true;
            _gameStateController.RunMainGameState();
        }
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
