using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private float _speed = 0.04f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed);
    }
}
