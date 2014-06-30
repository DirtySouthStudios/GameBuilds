// Francesco Maoli & Elmer Guerrero
// 6/30/2014
// 6/30/2014
// Assets/Scripts
// Empty Game Object (Rename to Object Pooler and attach bullet prefab in inspector component)

using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {

	public static ObjectPooler current;
	public GameObject pooledObject;
	public int pooledAmount = 10;
	public bool willGrow = true;

	List<GameObject> pooledObjects;

	void Awake (){
		current = this;
	}

	void Start () {
		pooledObjects = new List<GameObject> ();
		for (int i = 0; i < pooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate (pooledObject);
			obj.SetActive (false);
			pooledObjects.Add (obj);
		}
	}
	
	public GameObject GetPooledObject () {
		for(int i = 0; i < pooledObjects.Count; i++){
			if(!pooledObjects[i].activeInHierarchy){
				return pooledObjects[i];
			}
		}

		if(willGrow){
			GameObject obj = (GameObject)Instantiate(pooledObject);
			pooledObjects.Add(obj);
			return obj;
		}
		return null;
	}
}
