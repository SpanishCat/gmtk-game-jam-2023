using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITower
{
    public abstract void Attack();
    public abstract void Die();

    public void Regen();
    public short Damage(short damage);
    public short GetMaxHealth();
    public short GetHealth();
}
