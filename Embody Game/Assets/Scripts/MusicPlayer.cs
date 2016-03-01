using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	GameObject[] musicObject;

	// Use this for initialization
	void Start () {
        //GameObject.DontDestroyOnLoad(gameObject); //music from main menu keeps playing instead of being destroyed

        musicObject = GameObject.FindGameObjectsWithTag ("GameMusic");
        if (musicObject.Length == 1 ) {
        	GetComponent<AudioSource>();
        }
        														//persistent play throughout the game
        else {
        	for(int i = 1; i < musicObject.Length; i++)
        	{
        		Destroy(musicObject[i]);
        	}
        }

	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (this.gameObject); //don't destroy game object on load
	}
}
