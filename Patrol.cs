// Francesco
// 6/19/2014
// 6/24/2014
// Prototype2\Assets\Scripts
// Enemy Prefab object

using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

	public float moveSpeed;

	// Point Array Navigation variables
	public Transform[] patrolPoints;
	private int currentPoint;

	// Follow Player Navigation variables
	public Transform target;
	public Vector3 targetPosition;
	private Transform enemyTransform;

	void Start () {

		//Locate Patrol Points
		transform.position = patrolPoints [0].position;
		currentPoint = 0;

		// Locate Player
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		target = player.transform;

		// Locate Player Position
		targetPosition = player.transform.position;

		// Enemy Current Position
		GameObject enemy = this.gameObject;
		enemyTransform = enemy.transform;
	}
	

	void Update () {

		// Follow Player Indefinitely [Works]
		/* transform.LookAt(target);
		enemyTransform.position += enemyTransform.forward * moveSpeed * Time.deltaTime; */


		// Array Point Navigation [Works]
		/*if(transform.position == patrolPoints[currentPoint].position){
			currentPoint ++;
		}
		
		if (currentPoint >= patrolPoints.Length){ //If currentPoint is greater than the total amount of points
			currentPoint = 0;	//Set currentPoint back to zero
		}

		transform.position = Vector3.MoveTowards(transform.position, patrolPoints [currentPoint].position, moveSpeed * Time.deltaTime);
		*/
	}

	// Go to Player Position, then find new position of player [WIP], has yet to our intentions
	/*void GoToPlayerPos(){
			transform.LookAt (targetPosition);
			enemyTransform.position += enemyTransform.forward * moveSpeed * Time.deltaTime;
			enemyTransform.position += enemyTransform.forward * 1.2f * Time.deltaTime;
	}*/
}