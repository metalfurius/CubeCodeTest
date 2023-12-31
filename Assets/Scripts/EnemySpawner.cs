using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;

    private GameObject currentObject;

    void Start()
    {
        SpawnPrefab();
    }

    void FixedUpdate()
    {
        if (currentObject == null)
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        currentObject = Instantiate(prefab, transform.position, Quaternion.identity);
    }

}
