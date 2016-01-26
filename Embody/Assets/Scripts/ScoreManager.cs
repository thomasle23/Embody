using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText; //text of the current score, part 12 of tutorial series
    public Text hiScoreText; //text of the current high score

    public float scoreCount; //the current score count
    public float hiScoreCount; //the current high score count

    public float pointsPerSecond; //points earned for every second

    public bool scoreIncreasing; //score is increasing

	// Use this for initialization
	void Start () {
	    if(PlayerPrefs.HasKey("HighScore")) //check if there is a high score number on the computer
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore"); //get the float of the high score
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (scoreIncreasing) //check the score increasing box to make the score go up, if not checked score will not do anything
        {
            scoreCount += pointsPerSecond * Time.deltaTime; //points for every second in game
        }

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount); //if current score count higher than the high score, replace it, high score saves on computer
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount); //display current score text, round to whole numbers
        hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount); //display high score text, round to whole numbers
	}

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }


}
