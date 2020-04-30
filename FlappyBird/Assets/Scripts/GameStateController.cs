using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateController : MonoBehaviour
{
    private ObstacleBehaviour[] _obstaclesBehavioursComponent;

    [SerializeField] private Rigidbody2D _birdRigidbody;

    [Header("Scripts")]
    [SerializeField] private ObstaclePool _obstaclePool;
    [SerializeField] private ObstacleSpawner _obstacleSpawner;
    [SerializeField] private BirdVisualBehaviour _birdVisualBehaviour;
    [SerializeField] private BirdControll _birdControll;
    [SerializeField] private GroundMovement _groundMovement;

    [Header("UI")]
    [SerializeField] private GameObject _startUI;
    [SerializeField] private GameObject _mainGameUI;
    [SerializeField] private GameObject _endGameUI;

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
        _mainGameUI.SetActive(true);
    }

    /*public void RunEndGameState()
    {
        
    }*/
}
