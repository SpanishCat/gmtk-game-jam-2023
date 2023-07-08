using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    //readonly GameObject towerObject;
    readonly short maxHealth;
    readonly float cooldownSeconds;
    short health;

    public Tower(/*GameObject inTowerObject, */short inMaxHealth, float inCooldown = 0)
    {
        //towerObject = inTowerObject;
        maxHealth = inMaxHealth;
        cooldownSeconds = inCooldown;
        health = maxHealth;
    }

    public short Damage(short damage)
    {
        health -= damage;
        Mathf.Clamp(health, 0, maxHealth);

        if (health == 0) { Die(); }

        return health;
    }

    public void Die()
    {
        Debug.Log("Tower destroyed!");
    }
}
