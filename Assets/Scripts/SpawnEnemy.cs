using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	
	private int randomizer;
	private GameObject ship;
	
	void Start () {
		randomizer = Random.Range(0, 100);
		if(randomizer <76){
			ship = (GameObject) Resources.Load("BasicShip");
		}
		else{
			ship = (GameObject) Resources.Load("SecondShip");
		}
	}
	
	void OnTriggerExit(Collider other) {
	
		Instantiate(ship, transform.position, ship.transform.rotation);
		
	}
}
