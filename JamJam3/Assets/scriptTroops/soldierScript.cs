using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class soldierScript : MonoBehaviour
{
    public int HP;
    public float Damage;
    public int moveSpeed;
    public int attackSpeed;
    public bool isAttacking;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "50Soldier")
            Damage = Damage * 1.2f;
        if (gameObject.name == "100Soldier")
            Damage = Damage * 1.5f;
        if (gameObject.name == "500Soldier")
            Damage = Damage * 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
