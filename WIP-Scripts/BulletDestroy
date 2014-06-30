// Francesco Maoli & Elmer Guerrero
// 6/30/2014
// 6/30/2014
// Assets/Scripts
// Bullet Prefab


using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {

	void OnEnable () {
		Invoke ("Destroy", 2f);
	}
	
	void Destroy () {
		gameObject.SetActive (false);
	}

	void OnDisable () {
		CancelInvoke ();
	}
}
