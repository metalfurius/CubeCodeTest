using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    float speed = 5.0f;
    float amplitude = 2.0f;
    float frequency = 1.0f;
    bool destroyedByCollision = false;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        GetRandomValues();
    }

    private void GetRandomValues()
    {
        int randomNegative = Random.Range(0, 2) * 2 - 1;
        speed = Random.Range(3, 5);
        amplitude = Random.Range(2, 5)*randomNegative;
        frequency = Random.Range(2, 5)*randomNegative;
    }

    void FixedUpdate()
    {
        MoveForward();
        MoveSin();
    }

    private void MoveSin()
    {
        rb.velocity = new Vector3(0, 0, Mathf.Sin(Time.time * frequency) * amplitude);
    }

    private void MoveForward()
    {
        rb.velocity = new Vector3(Mathf.MoveTowards(rb.velocity.x, speed, speed * Time.deltaTime), rb.velocity.y, rb.velocity.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.instance.EndGame();
            destroyedByCollision = true;
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        if (!destroyedByCollision)
        {
            UIManager.instance.AddScore();
            Destroy(gameObject);
        }
    }

}
