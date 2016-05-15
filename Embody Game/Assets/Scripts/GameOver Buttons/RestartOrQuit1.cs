using UnityEngine;
using System.Collections;

public class RestartOrQuit1 : MonoBehaviour {


	public void BackToMain()
	{
		Application.LoadLevel(0); //Back to Main Menu
	}


    public void RestartGame()
    {
        Application.LoadLevel(2); //restart character 2
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
