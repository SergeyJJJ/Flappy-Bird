using System.Collections.Generic;
using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    private List<GameObject> _obtaclePool = new List<GameObject>();
    [SerializeField] private int _poolAmount = 10;
    [SerializeField] private GameObject _obstacle;

    public static ObstaclePool sharedInstance ;

    private void Awake()
    {
        sharedInstance = this;
    }

    private void Start()
    {
        for (var index = 0; index < _poolAmount; index++)
        {
            GameObject newObstacle;
            newObstacle = Instantiate(_obstacle, _obstacle.transform.position, Quaternion.identity);
            newObstacle.SetActive(false);
            _obtaclePool.Add(newObstacle);
            newObstacle.transform.SetParent(sharedInstance.transform);
        }   
    }

    public GameObject GetPooledObstacle()
    {
        for (var index = 0; index < _obtaclePool.Count; index++)
        {
            if (!_obtaclePool[index].activeInHierarchy)
            {
                return _obtaclePool[index];
            }
        }

        return null;
    }
}
