using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(gameObject); //when you press start game on the main menu the music keeps on playing isntead of being destroyed
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
