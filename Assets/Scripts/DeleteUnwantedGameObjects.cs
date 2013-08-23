using UnityEngine;
using System.Collections;

public class DeleteUnwantedGameObjects : MonoBehaviour {

	void OnTriggerExit(Collider other){
		Destroy(other);	
		
	}
	
	void OnCollisionEnter(Collision other){
		Destroy(other.gameObject);	
		
	}
}
