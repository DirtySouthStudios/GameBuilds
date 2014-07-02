// Francesco Maoli & Elmer Guerrero
// 6/30/2014
// 6/30/2014
// Assets/Scripts
// Empty Game Object (Rename to Object Pooler and attach bullet prefab in inspector component)

using UnityEngine;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {

	public static ObjectPooler current;
	public GameObject pooledObject; // This shows up in the inspector and is where the prefab is placed
	public int pooledAmount = 10;
	public bool willGrow = true;

	List<GameObject> pooledObjects;

	void Awake (){
		current = this; // Need this for other scripts that are dependent on the current state
	}

	void Start () {
		pooledObjects = new List<GameObject> (); // We used list because it allows for dynamic features that array cannot do
		for (int i = 0; i < pooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate (pooledObject); //Create a pooledObject
			obj.SetActive (false); // Make object inactive
			pooledObjects.Add (obj); // Add it to the pool
		}
	}
	// Grabs a pooledObject when it is needed
	public GameObject GetPooledObject () {
		for(int i = 0; i < pooledObjects.Count; i++){
			if(!pooledObjects[i].activeInHierarchy){ // If the object is not active in the hierarchy
				return pooledObjects[i]; // Make it active
			}
		}
		// If 10 objects is not enough, grow the list
		if(willGrow){
			GameObject obj = (GameObject)Instantiate(pooledObject);
			pooledObjects.Add(obj);
			return obj; // Return the object that was added
		}
		return null;
	}
}
