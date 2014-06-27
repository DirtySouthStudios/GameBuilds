// Francesco Maoli
// 6/26/2014
// 6/26/2014
// Assets/Scripts
// Attach to Bullet Prefab


 ---NOT YET TESTED---
using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {

	public float bulletSpeed;

	// Claim both the bullet and bullet casing as rigidbodies
	public Rigidbody bullet;
	public Rigidbody spentBullet;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Instantiate a bullet when the player hits the fire key
		if (Input.GetButtonDown("Fire")){
			Rigidbody clone;
			// Need to instantiate at the player's position
			clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
		}
	}

	// When hitting an enemy tag, bullet is destroyed
	void OnCollisionEnter (Collision other){
		if (other.transform.tag == "Enemy"){
			spentBullet = transform.position;
			Destroy();
			Rigidbody clone;
			clone = Instantiate(spentBullet, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.forward * 0);
		}
	}
}
