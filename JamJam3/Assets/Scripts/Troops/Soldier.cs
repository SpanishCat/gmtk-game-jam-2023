using UnityEngine;

public class Soldier : MonoBehaviour
{
    public static short hp;
    public static short attackDamage;
    public static short moveSpeed;
    public static short attackSpeed;
    public static bool isAttacking;

    public short GetHealth()
    {
        return hp;
    }

    void Start()
    {
        if (gameObject.name == "50Soldier")
            attackDamage *= (short) 1.2f;
        if (gameObject.name == "100Soldier")
            attackDamage *= (short) 1.5f;
        if (gameObject.name == "500Soldier")
            attackDamage *= (short) 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
