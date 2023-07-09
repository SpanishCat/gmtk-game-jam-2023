public class Giant : Soldier
{
    
    // Start is called before the first frame update
    void Start()
    {
      if(gameObject.name == "5Giants")
        {
            attackDamage += (short) (attackDamage * 1.4f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
