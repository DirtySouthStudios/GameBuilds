// Francesco Maoli & Elmer Guerrero
// 6/30/2014
// 7/2/2014
// Assets/Scripts
// Attach to Player Prefab

// ----!!!! Currently bullets fly foward but Player is knocked backwards as well !!!!!-----
using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

	public float bulletSpeed = 8;
	
	public Transform bullet;

	void Start () {
	}

	void FixedUpdate () {
		// Points ray to mouse position, claims needed raycasting variables for later use
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit = new RaycastHit();

		// For debugging purposes
		if (Physics.Raycast (ray, out hit, 100)) {
		}
		
		//Calls Object Pooling method when left click occurs
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log("Left Button Clicked");
			Fire ();
		}
	}

	void Fire () {
		GameObject obj = ObjectPooler.current.GetPooledObject();

		if (obj == null)return;
		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);
		
		
		// Should only add foward velocity to the bullet but currently sends player backwards as well
		rigidbody.velocity = bullet.transform.forward * bulletSpeed;
	}
}
