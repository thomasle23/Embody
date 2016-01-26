using UnityEngine;
using System.Collections;

public class DeathMenu : MonoBehaviour {

    public string mainMenuLevel;

    public void RestartGame()
    {
        FindObjectOfType<GameManager>().Reset(); //restart the game
    }

    public void QuitToMain()
    {
        Application.LoadLevel(mainMenuLevel); //goes back to the main menu
    }
}
