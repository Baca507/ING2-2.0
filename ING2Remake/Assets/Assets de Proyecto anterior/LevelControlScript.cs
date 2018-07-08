using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour {

	// Get references to game objects that should be disabled and enabled
	// at the start
	GameObject[] Pregunta1, Pregunta2, Pregunta3, Pregunta4, Pregunta5, Cierto, Falso, CiertoS, FalsoS, Info1, Info2, Info3, Info4, Info5;

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
        Info1 = GameObject.FindGameObjectsWithTag("Info1");
        Info2 = GameObject.FindGameObjectsWithTag("Info2");
        Info3 = GameObject.FindGameObjectsWithTag("Info3");
        Info4 = GameObject.FindGameObjectsWithTag("Info4");
        Info5 = GameObject.FindGameObjectsWithTag("Info5");
        Cierto = GameObject.FindGameObjectsWithTag("Cierto");
        Falso = GameObject.FindGameObjectsWithTag("Falso");
        CiertoS = GameObject.FindGameObjectsWithTag("CiertoS");
        FalsoS = GameObject.FindGameObjectsWithTag("FalsoS");
        Pregunta1 = GameObject.FindGameObjectsWithTag("Pregunta1");
        Pregunta2 = GameObject.FindGameObjectsWithTag("Pregunta2");
        Pregunta3 = GameObject.FindGameObjectsWithTag("Pregunta3");
        Pregunta4 = GameObject.FindGameObjectsWithTag("Pregunta4");
        Pregunta5 = GameObject.FindGameObjectsWithTag("Pregunta5");

        // Disabling game objects with tag
        foreach (GameObject element in Info1)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Info2)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Info3)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Info4)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Info5)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Pregunta1)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Pregunta2)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Pregunta3)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Pregunta4)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Pregunta5)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Cierto)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in CiertoS)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Falso)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in FalsoS)
        {
            element.gameObject.SetActive(false);
        }

    }

}
