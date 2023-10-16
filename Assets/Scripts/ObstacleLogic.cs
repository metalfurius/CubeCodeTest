using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLogic : MonoBehaviour
{
    private bool destroyedByCollision = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.instance.SubstractScore();
            destroyedByCollision = true;
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        if (!destroyedByCollision)
        {
            Destroy(gameObject);
        }
    }
}
