using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("d")){
			anim.Play("Rightwalk");
		}
		if(Input.GetKeyUp("d")){
			anim.Play("Idle");
		}

		if(Input.GetKeyDown("a")){
			anim.Play("Leftwalk");
		}
		if(Input.GetKeyUp("a")){
			anim.Play("Idle");
		}

		if(Input.GetKeyDown("w")){
			anim.Play("Frontwalk");
		}
		if(Input.GetKeyUp("w")){
			anim.Play("Idle");
		}
		if(Input.GetKeyDown("s")){
			anim.Play("Backwalk");
		}
		if(Input.GetKeyUp("s")){
			anim.Play("Idle");
		}
	}
}
