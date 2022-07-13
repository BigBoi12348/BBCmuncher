using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevelLoader : MonoBehaviour
{
    public string LevelToLoad;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("TutorialLevel");
    }

    public void Level1()
    {
        SceneManager.LoadScene("BobOmb");
    }

    public void Level2()
    {
        SceneManager.LoadScene("BoyInStrippedPajamas");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Scene3");
    }
}
