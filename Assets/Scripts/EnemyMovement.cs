using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMovement : MonoBehaviour
{
    float speed = 5.0f;
    float amplitude = 2.0f;
    float frequency = 1.0f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        GetRandomValues();
    }

    private void GetRandomValues()
    {
        speed = Random.Range(2, 5);
        amplitude = Random.Range(-4, 4);
        frequency = Random.Range(-4, 4);
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
        transform.Translate(speed * Time.deltaTime * Vector3.right);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
