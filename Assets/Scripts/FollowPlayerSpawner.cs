using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerSpawner : MonoBehaviour
{
    //public Transform player;
    public Vector3 offset;
    public Transform playerTransform;
    void LateUpdate()
    {
        SetPosition(playerTransform);
    }

    private void SetPosition(Transform playerpos)
    {
        transform.position = new Vector3(playerpos.position.x + offset.x, 0,0);
    }
}
