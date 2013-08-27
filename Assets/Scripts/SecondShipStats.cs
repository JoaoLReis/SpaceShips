using UnityEngine;
using System.Collections;

public class SecondShipStats : ShipStats {

	public SecondShipStats(){
		health = 5;		
		armor = 0.1f;
	}
	
	public override void decreaseHealth(float damage){
		health -= damage;
	}
}
