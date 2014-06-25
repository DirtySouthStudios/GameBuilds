 // Francesco
 // 6/19/2014
 // 6/24/2014
 // Prototype2\Assets\Scripts
 // Empty GameObject
 
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	// Score variables
	public static int currentScorer;
	public static int highScorer;
	
	// Level variables
	public static int currentLevel = 0;
	public static int unlockedLevel;

	// Time variables
	public Rect timerRect;
	public float startTime;
	private string currentTime;

	public GUISkin skin;


	void Update (){
		startTime -= Time.deltaTime; // Takes aways 1 second from each game time step from start time set in the component by user
		currentTime = string.Format("{0:0.0}", startTime) ; //Sets format for timer
	}

	void Start(){
		DontDestroyOnLoad (gameObject);
		Debug.Log ("I'm Here"); 
	}

	public static void CompleteLevel() {

		// Loads next level based on current level, only 3 levels so far so stops at 2
		if (currentLevel < 2) { 
			currentLevel += 1;
			Application.LoadLevel (currentLevel);
		}else{
			print ("You Win!");
		}
	}

	// Adds time GUI to game
	void OnGUI(){
		GUI.Label (timerRect, currentTime);
	}
}