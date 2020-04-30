using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    [SerializeField] private GameStateController _gameStateController;

    private void OnCollisionEnter2D(Collision2D other)
    {
        //_gameStateController.RunEndGameState();
    }
}
