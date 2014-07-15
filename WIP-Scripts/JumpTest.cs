// Francesco Maoli & Yang Song
// 7/7/2014
// 7/15/2014
// Assets/Scripts
// Player Prefab

using UnityEngine;
using System.Collections;

public class JumpTest : MonoBehaviour {
	
	// Jump variables
	private Vector3 input;
	public float jumpSpeed = 8f;
	private float maxJumpSpeed = 10f;
	public float gravity = 3f;
	
	// Directional variable
	private Vector3 moveDirection = Vector3.zero;

	// Boolean test
	private boolean grounded; // NEW
	private boolean goHigher;
	
	// Height variables NEW
	private float playerHeight;
	public float maxPlayerHeight;
	
	void FixedUpdate () {
		
		
		GroundedTest(); // NEW
		
		if (grounded){  // NEW
		
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
	
			
			// Needs Work
			if (Input.GetButton ("space")) {
				Debug.Log ("I jumped!");
				moveDirection.y = jumpSpeed;
				GoHigherTest(); // NEW
				if (goHigher){ // NEW
					rigidbody.AddRelativeForce (moveDirection * jumpSpeed);
				}
			}
		}
		
	}
	
	public GroundedTest(){ // NEW
		OnCollisionEnter(Collision collision){
			if (collision.gameObject.tag("Player")){
				grounded = true;
			}
		}
	}
	
	public GoHigherTest(){ // NEW
		
		playerHeight = transform.position.y;
		
		if(playerHeight < maxJumpHeight){
			goHigher = true;
		}
	}
}

