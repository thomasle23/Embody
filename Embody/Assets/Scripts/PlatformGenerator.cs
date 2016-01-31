using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

    public GameObject thePlatform; //platform generated ahead of player
    public Transform generationPoint; //platform generation point in game
    public float distanceBetween; //distance between each of the platforms


    public float distanceBetweenMin; //minimum distance between platforms
    public float distanceBetweenMax; //maximum distance between platforms

    private int platformSelector;
    private float[] platformWidths; //array for all the distance between the platform widths

    public ObjectPooler[] theObjectPools; //array of the object pools

    private float minHeight; //min height of platform, part 9 of tut series
    public Transform maxHeightPoint; //the max height point that the objects will be
    private float maxHeight; //maximum height
    public float maxHeightChange; //range of the max height change
    private float heightChange; //height change


	// Use this for initialization
	void Start () {

        platformWidths = new float[theObjectPools.Length]; //array of the object pools

        for (int i = 0; i < theObjectPools.Length; i++) 
        {
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x; //something to do with randomizing platforms, part 8 of tut series
        }

        minHeight = transform.position.y; //what is the minimum height
        maxHeight = maxHeightPoint.position.y; //what is the maximum height

	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < generationPoint.position.x) //if poistion of transform is less than generation point: if where we are is more to the left than the generation point
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax); //pick any number betweent the min and max numbers for distance between objects

            platformSelector = Random.Range(0, theObjectPools.Length); //variable length between the platforms, randomizing the lengths or something

            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange); //better platform generation things, move up or down based on values given randomly

            if(heightChange > maxHeight) //more platform generation optimizations, part 9 of tut series, platforms randomize better basically
            {
                heightChange = maxHeight; //change will go as high as the max height point
            }

            else if (heightChange < minHeight)
            {
                heightChange = minHeight; // lowest minimum height change will always be the minimum height point
            } 

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2 ) + distanceBetween, heightChange, transform.position.z); //moving platforms ahead 

           

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject(); //make new platform object in the pooled object things

            newPlatform.transform.position = transform.position; //what position the platform will be in
            newPlatform.transform.rotation = transform.rotation; //same rotation, no change
            newPlatform.SetActive(true); //set platform to true, not active by default


            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, transform.position.z);
        }
	
	}
}
