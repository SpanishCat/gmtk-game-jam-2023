using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float minDistance = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] shootables = GameObject.FindGameObjectsWithTag("Shootable");

        foreach (GameObject shootable in shootables)
        {
            if (Vector2.Distance(transform.position, shootable.transform.position) <= minDistance)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
