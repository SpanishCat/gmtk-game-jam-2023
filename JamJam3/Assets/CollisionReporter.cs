using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReporter : MonoBehaviour
{
    public static bool isEnemyInRange = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");

        isEnemyInRange = true;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Stay");

        if (!isEnemyInRange) { isEnemyInRange = true; }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit");
        isEnemyInRange = false;
    }
}
