using UnityEngine;
using System.Collections;

public class SpawnBasicShip : MonoBehaviour {
	
	
	public Transform basicShipPrefab;
    public Transform basicShipSpawn;
	//private Quaternion shipRotation = Quaternion.identity;
	
	void OnTriggerEnter(Collider other){
		Debug.Log ("enter");
		

	}
	
	void OnTriggerStay(Collider other){
		Debug.Log ("stay");

		
	}
	
	void OnTriggerExit(Collider other){
		Debug.Log ("exit");
		//shipRotation.Set(shipRotation.x,180, shipRotation.z,shipRotation.w);
		Instantiate(basicShipPrefab, basicShipSpawn.position, basicShipPrefab.rotation);
        //rocketInstance.AddForce(barrelEnd.forward * 5000);
		
	}
}
