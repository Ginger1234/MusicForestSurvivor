using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class pauseButton : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public static bool GameIsPaused = false; 
   // public Button[] NavButtons;

    public async void OnButtonDown()
    {
        if (GameIsPaused)
            {
                Resume();
            }
            else{
                Pause();
            }
    }
    public async void Resume()
    {
        
        PauseMenuUI.SetActive(false); //shows pause menu
        Time.timeScale = 1f; //makes the ingame time pass as real time
        GameIsPaused = false; 
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true); //hides pause menu
        
        Time.timeScale = 0f; //makes the ingame time stop
        GameIsPaused = true;
    }
}
