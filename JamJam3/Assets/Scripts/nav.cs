using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nav : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Transform target;
    private int wayPointIndx = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = wayPoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        target = wayPoints.points[wayPointIndx];
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            getNextWayPoint();

    }
    void getNextWayPoint()
    {
        if (wayPointIndx >= wayPoints.points.Length -1)
        {

            Destroy(gameObject);
            return;
        }

        wayPointIndx++;
        
    }
}
