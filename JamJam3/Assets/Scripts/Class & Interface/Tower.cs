using UnityEngine;

public abstract class Tower : MonoBehaviour, ITower
{
    public /*readonly*/ short maxHealth;
    public /*readonly*/ float cooldownSeconds;
    public short health;
    public float range = 5;

    //public Tower(short inMaxHealth, float inCooldown = 0)
    //{
    //    maxHealth = inMaxHealth;
    //    cooldownSeconds = inCooldown;
    //    health = maxHealth;

    //    Debug.Log("Max health: " + maxHealth);
    //}

    void Update()
    {
        Debug.Log(maxHealth);
    }

    // Abstracts
    public abstract void Attack();
    public abstract void Die();

    public void Regen()
    {
        health = maxHealth;
    }

    public short GetHealth() { return health; }

    public short GetMaxHealth() { return maxHealth; }

    public short Damage(short damage)
    {
        health -= damage;
        Mathf.Clamp(health, 0, maxHealth);

        if (health == 0) { Die(); }

        return health;
    }
}
