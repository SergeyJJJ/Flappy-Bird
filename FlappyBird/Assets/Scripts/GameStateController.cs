using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _birdRigidbody;
    [SerializeField] private ObstacleSpawner _obstacleSpawner;
    [SerializeField] private BirdVisualBehaviour _birdVisualBehaviour;
    [SerializeField] private GameObject _startUI;

    void Start()
    {
        RunPreGameState();
    }

    public void RunPreGameState()
    {
        _birdRigidbody.gravityScale = 0f;
        _birdVisualBehaviour.enabled = false;
        _obstacleSpawner.enabled = false;
    }

    public void RunMainGameState()
    {
        _startUI.SetActive(false);
        _birdRigidbody.gravityScale = 1f;
        _birdVisualBehaviour.enabled = true;
        _obstacleSpawner.enabled = true;
    }
}
