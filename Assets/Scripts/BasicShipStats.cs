using UnityEngine;
using System.Collections;

public class BasicShipStats : ShipStats {
	
	public BasicShipStats(){
		health = 4;		
		
	}
	
	public override void decreaseHealth(float damage){
		health -= damage;
	}
}