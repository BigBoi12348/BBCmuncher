using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string LevelToLoad;
    public void PlayGame()
    {
        SceneManager.LoadScene("Tree");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void WinReturnMenu()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        SceneManager.LoadScene("MainMenu");
    }

    public void LevelLoader()
    {
        SceneManager.LoadScene("Scene3");
    }
}
