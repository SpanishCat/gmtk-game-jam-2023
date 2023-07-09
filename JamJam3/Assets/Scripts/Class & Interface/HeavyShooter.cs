using UnityEngine;

public class HeavyShooter : Tower, ITower
{
    public GameObject bulletPrefab;

    // Auto
    float timeSinceLastAttack = 0;

    Transform shooter;
    GameObject currentTarget;


    void Start()
    {
        shooter = this.gameObject.transform;

        maxHealth = 3500;
        cooldownSeconds = 2f;
        damage = 30;

        Regen();
    }

    void Update()
    {
        // Update cooldown time
        timeSinceLastAttack += Time.deltaTime;


        GameObject[] targetsOnMap = GameObject.FindGameObjectsWithTag("Shootable");

        // If there's no target
        if (
            timeSinceLastAttack >= cooldownSeconds && 
            (currentTarget == null ||
            Vector2.Distance(shooter.position, currentTarget.transform.position) > range)
            )
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

        // If there is a target
        else if 
            (
            timeSinceLastAttack >= cooldownSeconds &&
            Vector2.Distance(shooter.position, currentTarget.transform.position) <= range
            )
        {
            timeSinceLastAttack = 0;
            Attack(); 
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

