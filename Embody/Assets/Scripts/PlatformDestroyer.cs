using UnityEngine;
using System.Collections;

public class PlatformDestroyer : MonoBehaviour {

    public GameObject platformDestructionPoint; //Should be called object destroyer, basically script for destroying objects

	// Use this for initialization
	void Start () {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint"); //when object finds the destruction point
	
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.x < platformDestructionPoint.transform.position.x) //if x position of an object is less than destruction point
        {
            //Destroy(gameObject); Destroy, apparently creates lag if done over and over again

            gameObject.SetActive(false);    //set to deactivate, apparently saves on memory or something


        }
	
	}
}
