using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomberScript : soldierScript
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "50Bombers")
            Damage = Damage * 1.2f;
        if (gameObject.name == "100Bombers")
            Damage = Damage * 1.5f;
        if (gameObject.name == "500Bombers")
            Damage = Damage * 1.8f;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
