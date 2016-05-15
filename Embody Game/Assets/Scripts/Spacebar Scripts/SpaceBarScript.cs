using UnityEngine;
using System.Collections;

public class SpaceBarScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) //when spacebar is pressed, restart game
		{
			Application.LoadLevel(3); //reload character scene 1
		}
	}


}
