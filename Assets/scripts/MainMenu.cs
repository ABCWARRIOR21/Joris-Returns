using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("Your Application is Closed");
        Application.Quit();
    }
}
