using System.Collections;
using UnityEngine;

public class BasicShooter : Tower
{
    // Projectile
    public const float bulletSpeed = 10f;

    Transform shooter;
    public GameObject bulletPrefab;
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
        if (Input.GetKeyDown(KeyCode.S)) { Attack(); }
        if (Input.GetKeyDown(KeyCode.D)) { Damage(1000); }
        if (Input.GetKeyDown(KeyCode.R)) { Regen(); }
        if (Input.GetKeyDown(KeyCode.H)) { Debug.Log(GetHealth()); }

        GameObject[] targetsOnMap = GameObject.FindGameObjectsWithTag("Shootable");

        if (true/*currentTarget == null || Vector2.Distance(shooter.position, currentTarget.transform.position) > range*/)
        {
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

        else if (Vector2.Distance(shooter.position, currentTarget.transform.position) <= range) 
        { Attack(); }
    }


    // Overrides
    public override void Attack()
    {
        Debug.Log("Shooter is attacking");

        Vector2 targetPos = currentTarget.transform.position;
        Vector2 shooterPos = shooter.position;
        Vector2 difference = targetPos - shooterPos;

        float distance = difference.magnitude;
        Vector2 direction = difference / distance;
        direction.Normalize();
        StartCoroutine("ShootAndWaitCooldown", direction);
    }

    private void FireBullet(Vector2 directions)
    {
        GameObject bullet = Instantiate(bulletPrefab, this.transform.position, this.transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody2D>().velocity = directions * bulletSpeed;
    }

    public override void Die()
    {
        Debug.Log("Tower died alone!");
        Destroy(this.gameObject);
    }

    IEnumerator ShootAndWaitCooldown(Vector2 directions)
    {
        FireBullet(directions);
        yield return new WaitForSeconds(cooldownSeconds);
    }



}
