using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string playGameLevel;

    public void PlayGame()
    {
        Application.LoadLevel(playGameLevel); //loads the game level
    }


    public void QuitGame()
    {
        Application.Quit(); //quits game
    }

}
