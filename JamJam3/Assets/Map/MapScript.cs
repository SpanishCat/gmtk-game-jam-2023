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
    private Vector2[] buildingLocationArray;
    private Vector2[] pathLocationArray;

    void Start()
    {
        buildingLocationArray = new Vector2[numOfBuildings];

        GameObject[] obj = GameObject.FindGameObjectsWithTag("Path");
        pathLocationArray = new Vector2[obj.Length];
        for (int i = 0; i < obj.Length; i++)
        {
            buildingLocationArray[i] = obj[i].transform.position;
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


        void SpawnBuilding(GameObject building)
        {
            var rand = new System.Random();
            Vector2 vec;
            int counter = 0;
            bool found = false;
            while (found == false && counter<300)
            {
                vec = new Vector2((float)(rand.Next(13) - 6.5 + rand.NextDouble()), (float)(rand.Next(17) - 6.5 + rand.NextDouble()));
            }
        }

        void CreatePath()
        {
            
        }
    }
}
