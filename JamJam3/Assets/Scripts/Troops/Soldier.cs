using UnityEngine;

public class Soldier : MonoBehaviour
{
    public static int HP;
    public static short attackDamage;
    public static int moveSpeed;
    public static int attackSpeed;
    public static bool isAttacking;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "50Soldier")
            attackDamage = attackDamage * 1.2f;
        if (gameObject.name == "100Soldier")
            attackDamage = attackDamage * 1.5f;
        if (gameObject.name == "500Soldier")
            attackDamage = attackDamage * 1.8f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
