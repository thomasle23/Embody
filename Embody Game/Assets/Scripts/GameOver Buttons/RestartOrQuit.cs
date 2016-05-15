using UnityEngine;
using System.Collections;

public class RestartOrQuit : MonoBehaviour {


	public void BackToMain()
	{
		Application.LoadLevel(0); //Back to Main Menu
	}


    public void RestartGame()
    {
        Application.LoadLevel(3); //restart character 1
    }

    public void RestartGame2()
    {
        Application.LoadLevel(4); //Restart the character 2 game
    }

    public void RestartGame3()
    {
        Application.LoadLevel(5); //Restart the character 3 game
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
