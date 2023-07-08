using UnityEngine;

public class shootingTester : MonoBehaviour
{

    private CircleCollider2D range;
    private CircleCollider2D target;
    private Vector3 Target;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;


    void Start()
    {
        range = gameObject.GetComponentInChildren<CircleCollider2D>();//getting the collision of the range object
        target = GameObject.FindGameObjectWithTag("Eneme").GetComponent<CircleCollider2D>();//every object tagged enemy is a potential collider
    }

    void Update()
    {
        if (range.IsTouching(target))//if an enemey is touching the
        {
            Target = target.transform.position;

            Vector3 difference = Target - this.gameObject.transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            this.gameObject.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);//sjooting the prefabs to the position
        }
        
    }
    void fireBullet (Vector2 directions, float rotationZ)//creating prefab to shoo to the location
    {
        GameObject Bulletfire = Instantiate(bulletPrefab) as GameObject;
        Bulletfire.transform.position = this.gameObject.transform.position;
        Bulletfire.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        Bulletfire.GetComponent<Rigidbody2D>().velocity = directions * bulletSpeed;
    }
}
