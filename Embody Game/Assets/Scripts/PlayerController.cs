using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // 5 - Shooting
        bool shoot = (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetMouseButtonDown(0)); //left shift or left mouse button
		shoot |= (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetMouseButtonDown(0));

        if (shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon != null)
            {
                // false because the player is not an enemy
                weapon.Attack(false);
            }
        }
    }
}
