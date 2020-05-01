using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    [SerializeField] private AudioHandler _audioHandler;
    private bool _isPlayed = false;
    private GameStateController _gameStateController;

    private void Start()
    {
        _gameStateController = FindObjectOfType<GameStateController>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _gameStateController.RunEndGameState();

        if (!_isPlayed)
        {
            _isPlayed = true;
            _audioHandler.PlayLose();
        }
    }
}
