using UnityEngine;

public class BirdVisualBehaviour : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody;    
    [SerializeField]private Animator _birdAnimations;
    private float _velocityToRotate = 0f;
    private bool _isAnimationActive = false;

    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
        Rotations();
    }

    private void Rotations()
    {
        if (_playerRigidbody.velocity.y <= _velocityToRotate)
        {
            DownwardRotation();
        }
        else
        {
            UpwardRotations();
        }
    }

    private void DownwardRotation()
    {
        Quaternion targetRotation = Quaternion.Euler(0, 0, -90);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.13f);

        if (transform.rotation.eulerAngles.z < 275 && transform.rotation.eulerAngles.z > 30)
        {
            _birdAnimations.SetBool("Fly", false);
            _isAnimationActive = false;
        }

    }

    private void UpwardRotations()
    {
        Quaternion targetRotation = Quaternion.Euler(0, 0, 20);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1f);

        if (_isAnimationActive == false)
        {
            _birdAnimations.SetBool("Fly", true); 
            _isAnimationActive = true;
        }
    }
}
