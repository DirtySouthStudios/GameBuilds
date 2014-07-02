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
	public Transform mouse;
	public Vector3 mousePosition;

	void Start () {
	}

	void FixedUpdate () {

		Ray mousePosition = Camera.main.ScreenPointToRay (Input.mousePosition);


		if (Input.GetMouseButtonDown (0)) {
			Debug.Log("Left Button Clicked");
			Fire ();
		}
	}

	void Fire () {
		// Create obj and place into object pool
		GameObject obj = ObjectPooler.current.GetPooledObject();

		if (obj == null)return;
		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;
		obj.SetActive (true);

		obj.transform.LookAt (mousePosition);
		obj.rigidbody.velocity = bullet.transform.forward * bulletSpeed;
	}
}
