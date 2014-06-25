// Francesco
// 6/19/2014
// 6/24/2014
// Prototype2\Assets\Scripts
// Any object that needs to be destroyed should call this script, not place it as a component

using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour{
	
	public float lifetime = 0;
	
	void Start () {
		Destroy(gameObject, lifetime);	
	}
	
	
	void Update () {
		
	}
}
