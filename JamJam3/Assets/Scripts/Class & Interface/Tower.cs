using UnityEngine;

public abstract class Tower : MonoBehaviour, ITower
{
    public /*readonly*/ short maxHealth;
    public /*readonly*/ float cooldownSeconds;
    public short health;
    public short damage = 1;
    public float range = 5;
    public const float bulletSpeed = 10;


    void Update()
    {
        Debug.Log(maxHealth);
    }

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


    // Abstracts
    public abstract void Attack();
    public abstract void Die();
}
