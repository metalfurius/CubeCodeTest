using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public List<GameObject> terrainObjects;
    public Transform playerTransform;
    public int terrainSize;
    public int distanceTrigger;
    int terrainCount;

    private void FixedUpdate()
    {
        bool nearEdge = playerTransform.position.x < (-terrainSize + distanceTrigger);
        if(nearEdge)
        {
            ChangeNextTerrainPosition();
        }
    }

    private void ChangeNextTerrainPosition()
    {
        terrainCount++;
        terrainObjects[terrainCount%3].GetComponent<Transform>().position = new(terrainCount * -terrainSize, 0, 0);
        distanceTrigger -= terrainSize;
    }
}
