using UnityEngine;
using System.Collections;

public class RestartOrQuit2 : MonoBehaviour {


	public void BackToMain()
	{
		Application.LoadLevel(0); //Back to Main Menu
	}


    public void RestartGame()
    {
        Application.LoadLevel(2); //restart to character selection
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
