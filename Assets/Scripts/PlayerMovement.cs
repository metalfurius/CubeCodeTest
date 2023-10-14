using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed, sideSpeed,jumpForce;
    Vector3 moveDirection;
    void Update()
    {
        GetMovementFromInput();
    }

    private void GetMovementFromInput()
    {
        var moveX = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(0, 0, moveX);
    }

    void FixedUpdate()
    {
        SideVelocity();
        ForwardVelocity();
    }

    private void ForwardVelocity()
    {
        transform.Translate(forwardSpeed * Time.deltaTime * Vector3.left);
    }

    private void SideVelocity()
    {
        rb.velocity += new Vector3(0, 0, moveDirection.z * sideSpeed);
    }
}
