using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giantScript : soldierScript
{
    
    // Start is called before the first frame update
    void Start()
    {
      if(gameObject.name == "5Giants")
        {
            Damage = Damage * 1.4f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
