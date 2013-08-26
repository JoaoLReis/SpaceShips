using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	
	private int randomizer;
	private GameObject ship;
	
	void Start () {
		
		for(int i = 0; i<181; i+=20){
			Invoke("randomizeShip", i);			
		}
		
	}
	
	void OnTriggerExit(Collider other) {
			
	}
	
	void randomizeShip(){
		
		randomizer = Random.Range(0, 100);
		if(randomizer <76){
			ship = (GameObject) Resources.Load("BasicShip");
		}
		else{
			ship = (GameObject) Resources.Load("SecondShip");
		}
		Instantiate(ship, transform.position, ship.transform.rotation);
	}
}
