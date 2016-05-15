using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void Tutorial()
    {
    	Application.LoadLevel(1); //tutorial screen
    }

    public void BacktoMain()
    {
    	Application.LoadLevel(0); //Back to Main Menu
    }

    public void PlayGame()
    {
        Application.LoadLevel(2); //Go to Character Selection
    }


    public void QuitGame()
    {
        Application.Quit(); //quit game
    }

}
