using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {

    public GameObject pooledObject; //what objects are we going to use, part 6 of tutorial series

    public int pooledAmount; //amount of objects that we're going to use

    List<GameObject> pooledObjects; //list of game objects

	// Use this for initialization
	void Start () {

        pooledObjects = new List<GameObject>(); //create list

        for(int i = 0; i < pooledAmount; i++) //forloop
        {
            GameObject obj = (GameObject)Instantiate(pooledObject); //game object cast so pooled object can be game object, something like that
            obj.SetActive(false); //create new object but not activated in scene
            pooledObjects.Add(obj); //add object into list
        }

	}
	
    public GameObject GetPooledObject() //get a pooled object, looking for a game object, confusing stuff
    {
        for(int i = 0; i <pooledObjects.Count; i++) //apparently makes object/platform pooling more optimized or something
        {
            if(!pooledObjects[i].activeInHierarchy) //return objects that have been inactive back into the game
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject); //same code as above
        obj.SetActive(false);
        pooledObjects.Add(obj);
        return obj; //return object to game

    }


}
