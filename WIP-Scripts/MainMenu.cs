// Francesco
// 6/19/2014
// 6/24/2014
// Prototype2\Assets\Scripts
// Main Camera on Main Menu level

using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GUISkin skin;

	void OnGUI(){

		GUI.skin = skin;
		GUI.Label (new Rect (10, 10, 400, 45), "Go Home");

		if (GUI.Button (new Rect (10, 150, 100, 45), "Play")) {
			Application.LoadLevel(0);		
		}

		if (GUI.Button (new Rect (10, 205, 100, 45), "Quit")) {
			//Application.Quit ();		
		}
	}
}


// Would like to make this more advanced, if you can please create a "Continue" button, that continues from the last known level completed
