using UnityEngine;

public class MapScript : MonoBehaviour
{
    public GameObject path;
    public GameObject tower;

    public int numOfBuildings;
    public double minDistFromPath;
    public double maxDistFromPath;

    private Vector2[] nodeLocationArray;

    void Start()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Path");
        nodeLocationArray = new Vector2[obj.Length + numOfBuildings];
        for (int i = 0; i < obj.Length; i++)
        {
            pathLocationArray[i] = obj[i].transform.position;
        }
        for (int i = 0; i < numOfBuildings; i++)
        {
            SpawnTower(tower);
        }
    }

    void SpawnTower(GameObject tower)
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
        Instantiate(tower, locationProposal, transform.rotation);
    }
}
