using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

   private float playerScore = 0;
   public GUISkin mySkin; //reference to GUISkin
  


	// Update is called once per frame
	void Update () {
        playerScore += Time.deltaTime;  
	}


    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Confidence", (int)(playerScore*100));
    }

    void OnGUI()
    {
   	GUI.skin = mySkin;
    	var mystyle = new GUIStyle();
    	mystyle.normal.textColor = GUI.skin.label.normal.textColor;
    	mystyle.fontSize = 40; //font size
        GUI.Label(new Rect(20, 20, 1000, 60), "Confidence: " + (int)(playerScore * 100), mystyle);
    }

}
