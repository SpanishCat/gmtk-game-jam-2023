using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counter : MonoBehaviour
{
    public gameOver gameOver;
    private bool flagger = false;
    public static int Count = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Count += collision.gameObject.GetComponent<Soldier>().GetHealth()/4;


    }
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        GameObject[] targetsOnMap = GameObject.FindGameObjectsWithTag("Shootable");
        if (GetComponentInChildren<Collider2D>() !=null ) 
        { 
            flagger = true;
        }
        if (flagger)
        {
            if(targetsOnMap.Length == 0 && Count == 0)
            {
                SceneManager.LoadScene("gameOver");
            }
            if (targetsOnMap.Length == 0 && Count >= 1)
            {
                gameOver.setUp(Count);
                SceneManager.LoadScene("winScreen");
            }
        }
    }
}
