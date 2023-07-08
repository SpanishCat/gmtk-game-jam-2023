using UnityEngine;

public class TowerTest : MonoBehaviour
{
    public GameObject basicShooter;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) { Instantiate(basicShooter); }

    }
}
