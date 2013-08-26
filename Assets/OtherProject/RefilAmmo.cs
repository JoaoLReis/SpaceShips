using UnityEngine;
using System.Collections;

public class RefilAmmo : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
		
		other.GetComponent<Inventory>().increaseAmmo();
		Destroy(this.gameObject);
		
	}
	
}
