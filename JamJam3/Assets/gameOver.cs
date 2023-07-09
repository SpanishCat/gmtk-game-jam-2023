using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public Text pointText;

    public void setUp(int score)
    {
        gameObject.SetActive(true);
        pointText.text = score.ToString() + " Points";
    }

    public void resetart()
    {
        SceneManager.LoadScene("Map");

    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
