using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnRepeatTime = 1.8f;
    private float _spawnDelay = 1.5f;
    private GameObject _pooledObstacle;
    private float _upperSpawnPosition = 6.21f;
    private float _lowerSpawnPosition = 3.19f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", _spawnDelay, _spawnRepeatTime);
    }

    private void SpawnObstacle()
    {
        _pooledObstacle = ObstaclePool.sharedInstance.GetPooledObstacle();

        if (_pooledObstacle != null)
        {
            _pooledObstacle.SetActive(true);
            _pooledObstacle.transform.position = GetRandomSpawnHight();
        }
    }

    private Vector2 GetRandomSpawnHight()
    {
        float randomHight = Random.Range(_lowerSpawnPosition, _upperSpawnPosition);
        return new Vector2(transform.position.x, randomHight);
    }
}
