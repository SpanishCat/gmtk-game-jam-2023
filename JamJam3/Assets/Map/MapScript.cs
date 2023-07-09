using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class MapScript : MonoBehaviour
{
    public GameObject path;
    public GameObject building;

    public int numOfBuildings;
    public double minDistFromPath;
    public double maxDistFromPath;
    public double minDistFromOthers;

    private Vector2[] buildingLocationArray;
    private Vector2[] pathLocationArray;

    void Start()
    {
        buildingLocationArray = new Vector2[numOfBuildings + 1];

        GameObject[] obj = GameObject.FindGameObjectsWithTag("Path");
        pathLocationArray = new Vector2[obj.Length];
        for (int i = 0; i < obj.Length; i++)
        {
            pathLocationArray[i] = obj[i].transform.position;
        }
        for (int i = 0; i < numOfBuildings; i++)
        {
            SpawnBuilding(building);
        }
    }
    void SpawnBuilding(GameObject building)
    {
        var rand = new System.Random();
        Vector2 locationProposal = new Vector2(0, 0);
        int tempCounter = 0;
        bool notOnPath = true;
        bool notOverlapping = true;
        bool found = false;
        while (!found && tempCounter < 300)
        {
            locationProposal = new Vector2((float)(rand.Next(13) - 6.5 + rand.NextDouble()), (float)(rand.Next(17) - 6.5 + rand.NextDouble()));
            for (int i = 0; i < pathLocationArray.Length && !found; i++)
            {
                if (Vector2.Distance(pathLocationArray[i], locationProposal) <= maxDistFromPath)
                {
/*                    for (int j = 0; buildingLocationArray[j] != null; j++)
                    {
                        if (Vector2.Distance(buildingLocationArray[j], locationProposal) < minDistFromOthers)
                            notOverlapping = false;
                    }*/
                    for (int j = 0; j < pathLocationArray.Length; j++)
                    {
                        if (Vector2.Distance(pathLocationArray[j], locationProposal) < minDistFromPath)
                            notOnPath = false;
                    }
                    if (notOverlapping && notOnPath)
                        found = true;
                    notOnPath = true;
                    notOverlapping = true;
                }
            }
            tempCounter++;
        }
        Instantiate(building, locationProposal, transform.rotation);
    }
    void CreatePath()
    {
            
    }
}
