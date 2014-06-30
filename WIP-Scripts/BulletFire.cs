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
		//InvokeRepeating ("Fire", fireTime, fireTime);
	}
	
	void Fire () {
		if(Input.GetMouseButtonDown(1)){
			GameObject obj = ObjectPooler.current.GetPooledObject();

			if (obj == null)return;
			obj.transform.position = transform.position;
			obj.transform.rotation = transform.rotation;
			obj.SetActive (true);
		}
	}
}
