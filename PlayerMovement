 // Francesco
 // 6/19/2014
 // 6/24/2014
 // Prototype2\Assets\Scripts
 // Player Prefab object
 
 
 
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Movement variables
	public float moveSpeed;
	private float maxSpeed = 5f;
	private Vector3 input;
	
	// Particle system
	public GameObject deathParticles;

	// Spawn locator
	private Vector3 spawn;


	void Start () {
		spawn = transform.position; //Set spawn to position at start of level
	}
	

	void FixedUpdate () {
		
		// Move based on axis input
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")); 
		
		// Add force relative to body
		if (rigidbody.velocity.magnitude < maxSpeed){
			rigidbody.AddRelativeForce (input * moveSpeed);
		}
		
		// Die when falling off platform
		if (transform.position.y < -4) {Die ();}
	}

	

	// Collision detection for enemy w/ player, and goal w/ player 
	void OnTriggerEnter (Collider other){

		if (other.transform.tag == "Enemy") {
			Die();
		}

		if (other.transform.tag == "Goal"){
			GameManager.CompleteLevel();
		}
	}

	// Trying to make the spawn wait for 4-5 seconds before respawning player, still a WIP
	void Die (){
		Instantiate(deathParticles, transform.position, Quaternion.Euler (270,0,0));
		//yield return new WaitForSeconds(4); 
		transform.position = spawn;
	}

}
