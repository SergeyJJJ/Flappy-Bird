using UnityEngine;
using UnityEngine.UI;

public class BirdScoreTracker : MonoBehaviour
{
    private int _score = 0;
    [SerializeField] private Text _scoreText;
    [SerializeField] private AudioHandler _audioHandler;


    private void Update()
    {
        _scoreText.text = _score.ToString();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        _score++;    
        _audioHandler.PlayPoint();
    }
}
