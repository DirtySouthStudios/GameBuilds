// Francesco Maoli & Elmer Guerrero
// 6/30/2014
// 6/30/2014
// Assets/Scripts
// Attach to Player Prefab

// ----!!!! Still needs work, currently bullets do not move and player Fire button is not functioning !!!!!-----
using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

	public float fireTime = .05f;

	void Start () {
	}
	
	void Fire () {
		if(Input.GetMouseButtonDown(1)){ 
			GameObject obj = ObjectPooler.current.GetPooledObject(); 
				
			if (obj == null)return;
			obj.transform.position = transform.position; // spawns from player pos
			obj.transform.rotation = transform.rotation; // spawns using player rot
			obj.SetActive (true); // Makes object active so it can interact and create trigger/collision events
			
			// Need something here that sends the bullet forward from the player position
		}
	}
}
