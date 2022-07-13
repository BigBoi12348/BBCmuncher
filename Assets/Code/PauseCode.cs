using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCode : MonoBehaviour
{
    public static bool gameIsPaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
            
        }
    }
    void PauseGame()
    {
        if (gameIsPaused)
        {
            //Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            //Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
