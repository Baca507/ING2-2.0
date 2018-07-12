using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

	public Animator anim;
	public bool displayMessage = false;
	public float displayTime;
	public string message;
	public GUIStyle MyStyle;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {
		displayTime -= Time.deltaTime;
     	if (displayTime <= 0.0f) {
         displayMessage = false;
		 }
	}

	void OnTriggerStay2D(Collider2D col){

		if(col.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)) {

			
			anim.Play("openchest");
			displayMessage = true;    
        	displayTime = 6.5f;
			

		}

	}

	void OnGUI () {
     if (displayMessage) {
         GUI.Box(new Rect (380,200,540,50), message);

		 //if(GUI.Button(new Rect(Screen.width / 2,200,290,20), "Metodo de Desarrollo de Sistemas Dinamicos")) {
        
        //}
     }
 }
}
