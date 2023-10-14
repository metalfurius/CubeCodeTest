using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    //public Transform player;
    public Vector3 offset;
    public Quaternion offsetAngle;
    public Transform playerTransform;

    private void Awake()
    {
        SetAngle();
    }
    void LateUpdate()
    {
        SetPosition(playerTransform);
    }

    private void SetAngle()
    {
        transform.rotation = offsetAngle;
    }

    private void SetPosition(Transform playerpos)
    {
        transform.position = playerpos.position + offset;
    }
}
