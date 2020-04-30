using UnityEngine;
using UnityEngine.UI;

public class BirdScoreTracker : MonoBehaviour
{
    private int _score = 0;
    [SerializeField] private Text _scoreText;

    private void Update()
    {
        _scoreText.text = _score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _score++;    
    }
}
