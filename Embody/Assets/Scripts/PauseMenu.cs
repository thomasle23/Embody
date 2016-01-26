using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string mainMenuLevel;

    public GameObject pauseMenu;

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true); //stops time and pauses the game
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false); //resume game when button pressed
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        FindObjectOfType<GameManager>().Reset(); //restart/reset game when pressed
    }

    public void QuitToMain()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(mainMenuLevel); //goes to main menu
    }
}
