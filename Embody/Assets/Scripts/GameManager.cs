using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Transform platformGenerator; //what is the platform generator, part 11 of tut series
    private Vector3 platformStartPoint;  //where do the platforms start
    
    public PlayerController thePlayer; //the player controller
    private Vector3 playerStartPoint; //the start point of the player

    private PlatformDestroyer[] platformList; //array for holding all the platforms that have been deactivated

    private ScoreManager theScoreManager; //call score manager script

    public DeathMenu theDeathScreen; //the death screen when you die

	// Use this for initialization
	void Start () {
        platformStartPoint = platformGenerator.position; //platform start point
        playerStartPoint = thePlayer.transform.position; //where the player starts

        theScoreManager = FindObjectOfType<ScoreManager>(); //find score manager in scene
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void RestartGame() //so the game can restart
    {
        theScoreManager.scoreIncreasing = false; 
        thePlayer.gameObject.SetActive(false); 

        theDeathScreen.gameObject.SetActive(true); //set the death screen active
    }

    public void Reset() //reseting the game resets stuff so nothing from previous game is left over
    {
        theDeathScreen.gameObject.SetActive(false);
        platformList = FindObjectsOfType<PlatformDestroyer>();
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0; //reset score to 0 after every game
        theScoreManager.scoreIncreasing = true; //score increases again after restarting the game
    }


}
