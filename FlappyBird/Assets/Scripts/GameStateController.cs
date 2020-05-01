using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateController : MonoBehaviour
{
    private ObstacleBehaviour[] _obstaclesBehaviour; 
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
        //_obstacleSpawner.enabled = false;
    }

    public void RunMainGameState()
    {
        _startUI.SetActive(false);
        _birdRigidbody.gravityScale = 1f;
        _birdVisualBehaviour.enabled = true;
        _obstacleSpawner.StartCoroutine("SpawnObstacleRoutine");
        _mainGameUI.SetActive(true);
    }

    public void RunEndGameState()
    {  
        _obstacleSpawner.StopCoroutine("SpawnObstacleRoutine");
        _groundMovement.enabled = false;
        _birdControll.enabled = false;
        _birdVisualBehaviour.StopAnimation();
        _birdVisualBehaviour.enabled = false;
        StopObstacleMovement();
        _mainGameUI.SetActive(false);
        _endGameUI.SetActive(true);
    }

    private void StopObstacleMovement()
    {
        _obstaclesBehaviour = _obstaclePool.GetComponentsInChildren<ObstacleBehaviour>();

        for (var index = 0; index < _obstaclesBehaviour.Length; index++)
        {
            _obstaclesBehaviour[index].StopMovement();
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
