using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaExamen : MonoBehaviour {

	public bool displayMessage = false;
	public float displayTime;
	public string message;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){

		if(col.gameObject.tag == "Player") {

			displayMessage = true;    
        	displayTime = 6.5f;
			

		}

	}

	void OnGUI () {
     if (displayMessage) {
         GUI.Box(new Rect (380,200,540,50), message);

		 if(GUI.Button(new Rect(480,300,150,20), "No")) {
			 displayMessage = false;
        
        }
		if(GUI.Button(new Rect(700,300,150,20), "si")) {
			
			
        
        }
     }
 }

}
