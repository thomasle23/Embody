using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer; //find player controller script to access it to find where the player actually is to follow

    private Vector3 lastPlayerPosition; //position of the player
    private float distanceToMove; //move camera at a certain amount as the player is moving

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>(); //find the player controller, which is the player
        lastPlayerPosition = thePlayer.transform.position; //value to see where the player is at beginnning of game
    }
	
	// Update is called once per frame
	void Update () {

        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x; //distance to move will equal the speed that the camera will be moving

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z); //only moves with x axis, something like that ^

        lastPlayerPosition = thePlayer.transform.position; //last player position is current player transform position, a bit confusing to me, #3 in tut series
	}
}
