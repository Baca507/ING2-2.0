using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitmap : MonoBehaviour {

	public bool displayMessage = false;
	public string message;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape)){
		displayMessage=true;
	}
		
	}
	

	void OnGUI () {
	
     if (displayMessage) {
         GUI.Box(new Rect (380,200,540,50), message);

		 if(GUI.Button(new Rect(480,300,150,20), "No")) {
			 displayMessage = false;
        
        }
		if(GUI.Button(new Rect(700,300,150,20), "si")) {
			
			Application.LoadLevel("SeleccMapa");
        
        }
     }
	
 }
	
}
