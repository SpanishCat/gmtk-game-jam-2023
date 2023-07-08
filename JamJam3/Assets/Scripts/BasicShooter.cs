using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicShooter : Tower
{
    readonly short maxHealth = 2000;
    readonly float cooldownSeconds = 0.1f;
    short health;

    public BasicShooter(short inMaxHealth, float inCooldown = 0) : base(inMaxHealth, inCooldown)
    {
        Regen();
    }

    public override void Attack()
    {
        Debug.Log("Shooter is attacking");
    }

    public override void Die()
    {
        Debug.Log("Tower died alone!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) { Attack(); }
        if (Input.GetKeyDown(KeyCode.D)) { Damage(10); }
        if (Input.GetKeyDown(KeyCode.R)) { Regen(); }
        if (Input.GetKeyDown(KeyCode.H)) { Debug.Log(GetHealth()); }

    }
}
