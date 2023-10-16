using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public List<GameObject> obstacles;
    public List<Transform> spawnPoints;
    private GameObject currentObject;

    void Start()
    {
        SpawnRandomPrefab();
    }

    void FixedUpdate()
    {
        if (currentObject == null)
        {
            SpawnRandomPrefab();
        }
    }

    void SpawnRandomPrefab()
    {
        int randomObstacleIndex = Random.Range(0, obstacles.Count);
        int randomSpawnPointIndex = Random.Range(0, spawnPoints.Count);
        currentObject = Instantiate(obstacles[randomObstacleIndex], spawnPoints[randomSpawnPointIndex].position, Quaternion.identity);
    }
}
