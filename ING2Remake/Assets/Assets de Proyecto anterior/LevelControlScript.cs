using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour {

	// Get references to game objects that should be disabled and enabled
	// at the start
	GameObject[] CiertoS, FalsoS;

    // References to game objects that should be enabled
    // when correct or incorrect answer is given
    public GameObject correctSign, incorrectSign;
    //cup, trophySing;

	// Variable to contain current scene build index
	//int currentSceneIndex;

	// Variable name to pass to Player Prefs meaning which variable to set as got
	// Adjustable in inspector depending on current scene and trophy
	// you earn (if you do)
	//public string whichCupGot = "Cup1Got";

	// Use this for initialization
	void Start () {

		// Getting current scene build index
		//currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;

		// Finding game objects with tags
        CiertoS = GameObject.FindGameObjectsWithTag("CiertoS");
        FalsoS = GameObject.FindGameObjectsWithTag("FalsoS");

        // Disabling game objects with tag
       
        
        foreach (GameObject element in CiertoS)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in FalsoS)
        {
            element.gameObject.SetActive(false);
        }

    }

}
