using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    // Main Menu
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Debug.Log("Exited Game");
        Application.Quit();
    }

    // Troop Placement
    public enum Target
    {
        Towers,
        Finishline
    }

    //public class TroopsOrder
    //{
    GameObject type;
    public short amount;
    //public Target target;
    public string target;

    public void SetType(GameObject troopType) { type = troopType; }
    public void SetAmount(short troopAmount) { amount = troopAmount; }
    public void SetTarget(string troopTarget) { target = troopTarget; }
    //}

    public void UpdateTarget()
    {
        Dropdown dropdown = GetComponent<Dropdown>();

        if (dropdown.options[0].text == "Attack Towers")
            SetTarget("Towers");
        else
            SetTarget("Finishline");
    }

    public Transform startStone;

    public void SendTroops()
    {
        //Debug.Log("Sending " + 
        //    " " + type.name + 
        //    "s for target: " + target);
        Instantiate(type,
            new Vector3(startStone.position.x, startStone.position.y, -0.7f),
            startStone.rotation);
    }
}
