using UnityEngine;
using System.Collections;

public class SecondShipStats : ShipStats {

	public SecondShipStats(){
		health = 6;		
		armor = 0.1f;
	}
	
	public override void decreaseHealth(float damage){
		Debug.Log("Decrease" + health);
		health -= damage;
		if(health <= 0){
			Destroy (gameObject);
		}
	}
}
