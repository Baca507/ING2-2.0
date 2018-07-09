using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

	public void changemenuscene (string scenename)
	{
		Application.LoadLevel(scenename);

	}
}
