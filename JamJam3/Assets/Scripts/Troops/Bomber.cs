public class Bomber : Soldier
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "50Bombers")
            attackDamage = (short) 1.2f;
        if (gameObject.name == "100Bombers")
            attackDamage = (short) 1.5f;
        if (gameObject.name == "500Bombers")
            attackDamage = (short) 1.8f;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
