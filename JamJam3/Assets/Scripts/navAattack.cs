using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class navAattack : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Transform target;
    private int wayPointIndx = 0;
    public float rangeDetect;
    private bool flag;
    private Tower Turret;
    
    // Start is called before the first frame update
    void Start()
    {
        target = wayPoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] targetsOnMap = GameObject.FindGameObjectsWithTag("Tower");
        foreach(GameObject target_ in targetsOnMap)
            {
            if (Vector2.Distance(gameObject.transform.position, target_.transform.position) <= rangeDetect)
            {
                flag = true;
                Turret = target_.GetComponent<Tower>();
                target = target_.transform;
                break;
            }
            else
                flag = false;
        }
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f && flag)
            getNextWayPoint();
        else
            Attack(Turret,soldierScript.attackDamage);

    }
    void getNextWayPoint()
    {
        if (wayPointIndx >= wayPoints.points.Length - 1)
        {

            Destroy(gameObject);
            return;
        }

        wayPointIndx++;
        target = wayPoints.points[wayPointIndx];
    }
    void Attack(Tower objective,short damage)
    {

        objective.Damage(damage);
    }
}
