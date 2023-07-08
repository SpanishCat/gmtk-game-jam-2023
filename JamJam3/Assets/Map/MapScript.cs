using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MapScript : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int[,] mapArray;

    void Start()
    {
        mapArray = new int[(int)transform.lossyScale.x , (int)transform.lossyScale.y];
        SpawnOject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnOject()
    {
        Vector3 position = new Vector3(0, 0, 0);
        GameObject newObject = Instantiate(objectToSpawn, position, objectToSpawn.transform.rotation);
    }
}
