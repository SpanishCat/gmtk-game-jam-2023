using UnityEngine;

public abstract class Tower : MonoBehaviour, ITower
{
    readonly short maxHealth;
    readonly float cooldownSeconds;
    short health;

    public Tower(short inMaxHealth, float inCooldown = 0)
    {
        maxHealth = inMaxHealth;
        cooldownSeconds = inCooldown;
        health = maxHealth;
    }

    // Abstracts
    public abstract void Attack();
    public abstract void Die();


    public void Regen()
    {
        health = maxHealth;
    }

    public short GetHealth()
    {
        return health;
    }

    public short Damage(short damage)
    {
        health -= damage;
        Mathf.Clamp(health, 0, maxHealth);

        if (health == 0) { Die(); }

        return health;
    }
}
