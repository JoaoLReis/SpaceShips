using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	
	private int randomizer;
	private GameObject ship;
	
	void Start () {
		
		for(int i = 5; i<186; i+=20){
			Invoke("randomizeShip", i);			
		}
	}
	
	void randomizeShip(){
		
		randomizer = Random.Range(0, 100);
		if(randomizer <75){
			ship = (GameObject) Resources.Load("BasicShip");
			StartCoroutine(spawnBasicEnemy());
		}
		else{
			ship = (GameObject) Resources.Load("SecondShip");
			spawnSecondShip();
		}
		
	}
	
	IEnumerator spawnBasicEnemy(){
		for(int i = 0; i<3;i++){
			Instantiate(ship, transform.position, ship.transform.rotation);
			yield return new WaitForSeconds(2);
		}
	}
	
	void spawnSecondShip(){
			
		Instantiate(ship, transform.position, ship.transform.rotation);
	}
	
	
}
