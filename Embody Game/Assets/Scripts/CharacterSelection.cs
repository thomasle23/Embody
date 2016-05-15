using UnityEngine;
using System.Collections;

public class CharacterSelection : MonoBehaviour {

    public void Character1()
    {
        Application.LoadLevel(3); //load character 1 scene
    }

    public void Character2()
    {
        Application.LoadLevel(4); //load character 2 scene
    }

    public void Character3()
    {
        Application.LoadLevel(5); //load character 3 scene
    }
}
