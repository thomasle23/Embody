﻿using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour {

	public bool isPaused;
	public GameObject pauseMenuCanvas;

	// Update is called once per frame
	void Update () {

		if(isPaused)
		{
			pauseMenuCanvas.SetActive(true);
			Time.timeScale = 0f;
		}

		else 
		{
			pauseMenuCanvas.SetActive(false);
			Time.timeScale = 1f;
		}

		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) //Press ESC or P key to Pause the Game
		{
			isPaused = !isPaused;
		}

	}

	public void Resume()
	{
		isPaused = false;
	}

	public void Restart()
	{
		Application.LoadLevel(3); //Restart the character 1 game
	}

    public void Restart2()
    {
        Application.LoadLevel(4); //Restart the character 2 game
    }

    public void Restart3()
    {
        Application.LoadLevel(5); //Restart the character 1 game
    }

    public void QuitToMain()
	{
		Application.LoadLevel(0); //Go to Main Menu
	}


}
