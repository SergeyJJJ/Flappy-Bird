using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed = 0.04f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed);
    }


    public void StopMovement()
    {
        _speed = 0f;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("TurnOffObstacle"))
        {
            gameObject.SetActive(false);
        }
    }
}
