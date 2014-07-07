// Francesco Maoli & Yang Song
// 7/7/2014
// 7/7/2014
// Assets/Scripts
// Player Prefab

using UnityEngine;
using System.Collections;

public class JumpTest : MonoBehaviour {
	
	
	private Vector3 input;
	public float jumpSpeed = 8f;
	private float maxJumpSpeed = 10f;
	public float gravity = 3f;

	private float playerHeight;

	private Vector3 moveDirection = Vector3.zero;


	void FixedUpdate () {


		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);


		// Needs Work
		if (Input.GetButton ("space")) {
			Debug.Log ("I jumped!");
			moveDirection.y = jumpSpeed;
			if (rigidbody.velocity.magnitude < maxJumpSpeed){
				rigidbody.AddRelativeForce (moveDirection * jumpSpeed);
			}
		}

		// Apply gravity
		//moveDirection.y -= gravity * Time.deltaTime;

		/*if (rigidbody.velocity.magnitude < maxHeight){
		rigidbody.AddRelativeForce (input * jumpHeight);
		}	*/
	}
}
