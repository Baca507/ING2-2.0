using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones : MonoBehaviour {

	public bool displayMessage = true;
	public string message;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI () {
	
     if (displayMessage) {
         GUI.Box(new Rect (380,200,540,50), message);

		 if(GUI.Button(new Rect(570,300,150,20), "OK")) {
			 displayMessage = false;
        
        }
     }
	
 }
}
