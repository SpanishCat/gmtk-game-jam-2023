using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class shootingTester : MonoBehaviour
{

    public CircleCollider2D range;
    public CircleCollider2D collider;
    private Vector3 Target; 
    public GameObject basicShooter;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        range = gameObject.GetComponentInChildren<CircleCollider2D>();//getting the collision of the range object
        collider = GameObject.FindGameObjectWithTag("Eneme").GetComponent<CircleCollider2D>();//every object tagged enemy is a potential collider
    }

    // Update is called once per frame
    void Update()
    {
        
        if (range.IsTouching(collider))//if an enemey is touching the
        {
            Target = collider.transform.position;

            Vector3 difference = Target - basicShooter.transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            basicShooter.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);//sjooting the prefabs to the position
        }
        
    }
    void fireBullet (Vector2 directions, float rotationZ)//creating prefab to shoo to the location
    {
        GameObject Bulletfire = Instantiate(bulletPrefab) as GameObject;
        Bulletfire.transform.position = basicShooter.transform.position;
        Bulletfire.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        Bulletfire.GetComponent<Rigidbody2D>().velocity = directions * bulletSpeed;
    }
}
