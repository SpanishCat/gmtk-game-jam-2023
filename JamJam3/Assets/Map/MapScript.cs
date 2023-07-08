using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MapScript : MonoBehaviour
{
    public GameObject path;
    public GameObject building;

    public int numOfBuildings;
    public Vector2[] buildingLocationArray;
    public Vector2[] pathLocationArray = new Vector2[42];

    void Start()
    {
        buildingLocationArray = new Vector2[numOfBuildings];

        int counter = 0;
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Path");
        foreach (GameObject o in obj)
        {
            buildingLocationArray[counter] = o.transform.position;
            counter++;
        }

        // spawns building on mouse click location
        /*    void Update()
            {
                if(Input.GetMouseButtonDown(0))
                {
                    Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    pos = new Vector3(pos.x, 0, pos.z);
                    Instantiate(spawnObject, pos, transform.rotation);
                }
            }*/


        void SpawnOject()
        {

        }

        void CreatePath()
        {
            
        }
    }
}
