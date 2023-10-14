using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;

    private GameObject currentObject;

    void Start()
    {
        SpawnNextPrefab();
    }

    void FixedUpdate()
    {
        if (currentObject == null)
        {
            SpawnNextPrefab();
        }
    }

    void SpawnNextPrefab()
    {
        currentObject = Instantiate(prefab, transform.position, Quaternion.identity);
    }

}
