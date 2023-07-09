using System.Collections;
using UnityEngine;

public class BasicShooter : Tower
{
    public GameObject bulletPrefab;

    // Auto
    float timeSinceLastAttack = 0;
    Transform shooter;
    GameObject currentTarget;

    void Start()
    {
        shooter = this.gameObject.transform;

        maxHealth = 2000;
        cooldownSeconds = 0.1f;

        Regen();
    }

    void Update()
    {
        timeSinceLastAttack += Time.deltaTime;

        GameObject[] targetsOnMap = GameObject.FindGameObjectsWithTag("Shootable");

        // Check when to attack
        if (timeSinceLastAttack >= cooldownSeconds)
        {
            timeSinceLastAttack = 0;

            foreach (GameObject target_ in targetsOnMap)
            {
                if (Vector2.Distance(shooter.position, target_.transform.position) <= range)
                {
                    currentTarget = target_;
                    Attack();
                    break;
                }
            }

        }
    }


    // Overrides
    public override void Attack()
    {
        Vector2 targetPos = currentTarget.transform.position;
        Vector2 shooterPos = shooter.position;
        Vector2 difference = targetPos - shooterPos;

        float distance = difference.magnitude;
        Vector2 direction = difference / distance;
        direction.Normalize();
        FireBullet(direction);
    }

    private void FireBullet(Vector2 directions)
    {
        GameObject bullet = Instantiate(bulletPrefab, this.transform.position, this.transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody2D>().velocity = directions * bulletSpeed;
    }

    public override void Die()
    {
        Destroy(this.gameObject);
    }
}
