using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcInteraction : MonoBehaviour {


	public bool displayMessage = false;
	public float displayTime;
	public string message;
	public GUIStyle MyStyle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		displayTime -= Time.deltaTime;
     	if (displayTime <= 0.0f) {
         displayMessage = false;
		 }
	}

	void OnTriggerStay2D(Collider2D col){

		if(col.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)) {

			displayMessage = true;    
        	displayTime = 3.0f;
			

		}

	}

	void OnGUI () {
     if (displayMessage) {
         GUI.Box(new Rect (380,200,390,70), message);

		 //if(GUI.Button(new Rect(Screen.width / 2,200,290,20), "Metodo de Desarrollo de Sistemas Dinamicos")) {
        
        //}
     }
 }
}
