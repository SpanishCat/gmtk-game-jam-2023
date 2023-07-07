using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void Play()
    {
        //SceneManager.SetActiveScene(0);
    }

    public void Quit()
    {
        Debug.Log("Exited Game");
        Application.Quit();
    }
}
