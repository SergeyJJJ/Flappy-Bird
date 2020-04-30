using UnityEngine;

public class BirdVisualBehaviour : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody;    

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
        if (_playerRigidbody.velocity.y <= 0)
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

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.15f);
    }
}
